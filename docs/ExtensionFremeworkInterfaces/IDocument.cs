using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// ドキュメントの編集を実現するインタフェースです。
	/// </summary>
	public interface IDocument : IEntityBase
	{
		#region 公開プロパティ

		/// <summary>
		/// ドキュメント名（表示用の名前）を取得・設定します。
		/// </summary>
		/// <value>ドキュメント名の文字列。</value>
		string Name { get; set; }

		/// <summary>
		/// ドキュメントが所有する関連リンクのコレクションの先頭要素の絶対パスを取得・設定します。
		/// </summary>
		/// <value>関連リンクのコレクションの先頭要素の絶対パスの文字列。</value>
		[Obsolete("本プロパティの代わりに、FirstDocumentLinkPathを使用してください。")]
		string AbsolutePath { get; set; }

		/// <summary>
		/// ドキュメントの関連リンクの一覧を取得します。
		/// </summary>
		/// <value>ドキュメントの関連リンクの一覧。</value>
		IEntityCollection<IDocumentLink> DocumentLinks { get; }

		/// <summary>
		/// ドキュメントの関連リンクの一つ目のパスを取得します。
		/// </summary>
		/// <value>ドキュメントの関連リンクの一つ目のパス。</value>
		string FirstDocumentLinkPath { get; set; }

		/// <summary>
		/// アウトラインツリーのルートノードを取得します。
		/// </summary>
		/// <value>アウトラインツリーのルートノード。</value>
		IOutlineNode OutlineTree { get; }

		/// <summary>
		/// すべてのノードのアウトライン順コレクションを取得します。
		/// </summary>
		/// <remarks>
		/// 取得できるコレクションは、深さ優先で全ノードを収集した結果のフラットなコレクションです。
		/// </remarks>
		/// <value> すべてのノードのアウトライン順コレクション。</value>
		IEnumerable<IOutlineNode> AllNodes { get; }

		/// <summary>
		/// ドキュメントに関連づいているアプリケーションを取得・設定します。
		/// </summary>
		/// <value>
		/// ドキュメントに関連づいているアプリケーションの名前。
		/// "EXCEL","WORD","POWERPOINT","PDF"が取得・設定できます。
		/// アプリケーションが関連づいていない場合はnullです。
		/// </value>
		string ApplicationType { get; set; }

		#endregion

		#region 公開メソッド

		/// <summary>
		/// 指摘を追加します。
		/// </summary>
		/// <returns>追加した指摘。</returns>
		IIssue AddIssue();

		#endregion

	}

}