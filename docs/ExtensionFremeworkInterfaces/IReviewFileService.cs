using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview
{
	/// <summary>
	/// レビューファイルをReviewWindowを伴わずに編集を実現するサービスのインターフェース
	/// </summary>
	public interface IReviewFileService
	{
		#region 公開サービス

		/// <summary>
		/// レビューを新規作成します
		/// </summary>
		/// <returns>レビュー</returns>
		IReview NewReview();

		/// <summary>
		/// レビューを開きます。
		/// 開くことに失敗した場合はUserExceptionをthrowします。
		/// </summary>
		/// <param name="filepath">レビューファイルのパス</param>
		/// <param name="readOnly">
		/// 読み取り専用として開くか
		/// 読み取り専用で開くと、他のユーザーがレビューファイルを開いていても開くことができる。
		/// </param>
		/// <returns>開いたレビュー</returns>
		IReview OpenReview(string filepath, bool readOnly = false);

		/// <summary>
		/// レビューを保存します
		/// </summary>
		/// <param name="filepath">レビューファイルのパス</param>
		/// <param name="review">レビュー</param>
		void SaveReview(string filepath, IReview review);

		/// <summary>
		/// レビューを閉じます
		/// </summary>
		/// <param name="review">レビュー</param>
		void CloseReview(IReview review);

		#endregion
	}
}
