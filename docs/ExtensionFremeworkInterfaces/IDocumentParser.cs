using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// ドキュメントのアウトライン解析を実現するインタフェースです。
	/// </summary>
	public interface IDocumentParser
	{
		#region プロパティ

		/// <summary>
		/// パーサーが対応している拡張子の一覧を取得します。
		/// </summary>
		/// <value>パーサーが対応している拡張子の一覧。</value>
		IEnumerable<string> FileExtensions { get; }

		#endregion

		#region 公開サービス

		/// <summary>
		/// パーサーが指定したファイルの拡張子に対応しているかを検証します。
		/// </summary>
		/// <param name="filePath">検証対象のファイルパス。</param>
		/// <returns>パーサーが指定したファイルの拡張子に対応しているか。対応している場合はtrue、それ以外はfalseです。</returns>
		bool IsParserFor(string filePath);

		/// <summary>
		/// ドキュメントをアウトライン解析します。
		/// </summary>
		/// <param name="document">アウトライン解析対象のドキュメント。</param>
		/// <param name="filePath">アウトライン解析対象のファイルパス。</param>
		/// <returns>アウトライン解析が成功したか。成功した場合はtrue、それ以外はfalseです。</returns>
		bool Parse(IDocument document, string filePath = "");

		/// <summary>
		/// ドキュメントの該当位置にジャンプします。
		/// </summary>
		/// <param name="document">ジャンプする対象のドキュメント。</param>
		/// <param name="physicalLocationXml">ジャンプする対象の位置。</param>
		/// <param name="filePath">ジャンプする対象のファイルパス。</param>
		/// <returns>ジャンプが成功したか。成功した場合はtrue、それ以外はfalseです。</returns>
		bool Jump(IDocument document, string physicalLocationXml, string filePath = "");

		#endregion
	}
}