#nullable enable
using LightningReview.ExtensionFramework;

namespace DensoCreate.Lakewood.Extensions.MarkdownDocumentParser
{
	/// <summary>
	/// Markdownのアウトライン解析のエクステンション
	/// </summary>
	/// <remarks>見出しにスラッシュを含む場合は、ノード名が[ノード]となる。これは制約とする。</remarks>
	[ExtensionExport("DensoCreate.MarkdownDocumentParser", "Markdownのアウトライン解析", "MarkdownDocumentParser")]
	public class MarkdownDocumentParserExtension : Extension
	{
		/// <summary>
		/// アクティベート処理
		/// </summary>
		protected override void OnActivate()
		{
			// パーサの登録
			RegisterDocumentParser<MarkdownDocumentParser>();
		}
	}
}
