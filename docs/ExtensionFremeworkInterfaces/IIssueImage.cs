using System.Windows.Media.Imaging;

namespace LightningReview.ExtensionFramework.LightningReview
{
	/// <summary>
	/// 指摘画像の編集を実現するインタフェース
	/// </summary>
	public interface IIssueImage : IEntityBase
	{
		#region プロパティ

		/// <summary>
		/// 画像名(ID=1-1の修正画像の場合は'1-1'となる)
		/// </summary>
		string Name { get; }

		/// <summary>
		/// 画像のイメージ
		/// </summary>
		BitmapImage Image { get; }

		/// <summary>
		/// 関連する指摘画像の番号(ID=1-1の修正画像の場合は'1'となる)
		/// </summary>
		int ReportedImageNo { get; }

		/// <summary>
		/// イメージ保存先のテンポラリフォルダのパス
		/// </summary>
		string ImageTemporaryFilePath { get; }

		#endregion
	}
}