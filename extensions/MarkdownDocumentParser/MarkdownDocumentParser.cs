using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using LightningReview.ExtensionFramework;
using Markdig;
using Markdig.Syntax;

namespace DensoCreate.Lakewood.Extensions.MarkdownDocumentParser
{
	/// <summary>
	/// Markdownのアウトライン解析を行うクラス
	/// </summary>
	public class MarkdownDocumentParser : DocumentParser 
	{
		#region 定数

		/// <summary>
		/// ジャンプ可能なURIスキーマの接頭辞
		/// ジャンプ可能とするURIスキーマをhttp:とhttps:の2種類に限定している理由は以下の2点である。
		/// ・mailto:やlr:といったカスタムURIスキーマへのジャンプを許容することも考えたが、その場合処理が複雑になってしまうため。
		/// ・http:とhttps:以外のURIスキーマを利用するユースケースがそもそもないと考えたため。
		/// </summary>
		private static readonly string[] c_URLPrefix = { "http://", "https://" };

		#endregion

		#region 構築 

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MarkdownDocumentParser() 
		{ 
			AddFileExtension(".md");
		}
		
		#endregion
		
		#region オーバーライド

		/// <summary>
		/// アウトライン解析する
		/// </summary>
		/// <param name="document">対象のドキュメント</param>
		/// <param name="filePath">対象のファイルパス</param>
		/// <returns>アウトライン解析が成功したか</returns>
		public override bool Parse(IDocument document, string filePath = "")
		{
			var targetPath = document.FirstDocumentLinkPath;
			// ジャンプする対象のファイルパスがある場合、そちらを用いてジャンプする
			if (!string.IsNullOrEmpty(filePath))
			{
				targetPath = filePath;
			}

			// ファイルパスがない場合はアウトライン解析をしない
			if (string.IsNullOrEmpty(targetPath))
			{
				return false;
			}

			// ファイルパスがURLの場合はアウトライン解析をしない
			// 本体側のURLに対するアウトライン解析実行時の挙動との一貫性のため、trueを返しエラーメッセージを表示しない
			if (IsUrl(targetPath))
			{
				return true;
			}

			// ファイルの読み込み
			var mdText = File.ReadAllText(targetPath);
		
			// Markdownの構文解析
			// 第2引数は構文解析機能を拡張するために使用するが、
			// 今回は見出し(#)が解析できれば良いので必要ない。参考サイトは以下。
			// https://machdesign.net/blog/article/markdig
			var md = Markdown.Parse(mdText); 

			// 構文解析したものから見出しを抽出
			// Descendantsメソッドで構文ごとの情報(#など)を取得できる。
			// <HeadingBlock>指定することで、見出し情報を取得できる。参考サイトは以下。
			// https://github.com/lunet-io/markdig/blob/master/src/Markdig/Syntax/MarkdownObjectExtensions.cs
			var headings = md.Descendants<HeadingBlock>().ToList();
			
			// 前回の見出しレベルより現在の見出しレベルが高くなる場合に親ノードを指定するためのスタック
			// 前回の見出しレベルより現在の見出しレベルが下がる度に
			// アウトラインノード及び見出し情報をそれぞれのスタックにプッシュする
			var stack = new Stack<IOutlineNode>();
			var headingsStack = new Stack<HeadingBlock>();

			// 前回の見出し情報
			HeadingBlock lastItem = null;

			// 前回のアウトラインノード
			IOutlineNode lastNode = null;

			// 親ノード
			IOutlineNode parent = null;

			// 最初はドキュメントが親ノードになるのでプッシュしておく
			stack.Push(document.OutlineTree);

			// #(h1)がいくつあるか
			var h1Count = headings.Count(h=>h.Level==1);

			// アウトライン構造を作成する
			foreach (var heading in headings) 
			{
				// 現在の見田しのレベルが#(h1)で、#(h1)が一つしかなければスキップ
				if (heading.Level == 1 && h1Count <= 1)
				{
					continue;
				}

				// 最初はアウトラインツリーのドキュメントを親ノードとする
				if ( lastItem == null )
				{
					parent = document.OutlineTree;
				}
				     
				// 前回の見出しと現在の見出しレベルが同じ場合
				else if (heading.Level == lastItem.Level)
				{
					// 同じレベルなので同じ親ノードになる
				}

				// 前回の見出しより現在の見出しレベルが下がった場合、前回の見出しが親ノードとなる
				else if ( heading.Level > lastItem.Level )
				{
					parent = lastNode;
					stack.Push(parent);
					headingsStack.Push(lastItem);
				}

				// 前回の見出しレベルより現在の見出しレベルが上がった場合
				// スタックピークの見出しレベルが現在の見出しレベル以上になるまでスタックからポップする。
				// ポップ後、スタックのピークにいるアウトラインノードが親ノードになる。
				else if ( heading.Level < lastItem.Level)
				{
					var count = headingsStack.Count;
					for (int i = 0; i < count; i++)
					{
						if(headingsStack.Peek().Level >= heading.Level)
						{
							stack.Pop();
							headingsStack.Pop();
						}
						else
						{
							break;
						}
					}

					parent = stack.Peek();
				}

				// アウトラインノード名の決定
				// Inline.FirstChildやLastChildで実際の見出しの要素(名前)取得できる。
				// 見出しのため複数個要素があるわけではないので基本的にはFirstChildとLastChildは同じものが入っている。参考サイトは以下。
				// https://github.com/lunet-io/markdig/blob/master/src/Markdig/Syntax/Inlines/ContainerInline.cs
				// inline、firstChild、lastChildは本来であればnullとなることはないと想定しているが、null許容参照型として定義されているため、
				// nullの場合は、フェールセーフで、当該アウトラインを生成できなくても他のアウトラインを生成するためにcontinueする
				var inline = heading.Inline;
				if (inline == null) continue;
				var firstChild = inline.FirstChild?.ToString();
				var lastChild = inline.LastChild?.ToString();
				if (firstChild == null || lastChild == null) continue;
				var title = firstChild != lastChild ? firstChild + lastChild : firstChild;

				var node = parent.AddChild(title);
				lastItem = heading;
				lastNode = node;
			}
			
			return true;
		}

		#endregion

		#region 内部サービス

		/// <summary>
		/// パスがURLかどうか
		/// </summary>
		/// <param name="path">パス</param>
		/// <returns>パスがURLかどうか</returns>
		private static bool IsUrl(string path)
		{
			foreach (var prefix in c_URLPrefix)
			{
				if (path.StartsWith(prefix))
				{
					return true;
				}
			}

			return false;
		}

		#endregion
	}
}
