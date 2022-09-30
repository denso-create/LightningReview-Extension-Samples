using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// レビューエクスプローラの編集を実現するインターフェース
	/// </summary>
	public interface IReviewExplorer
	{
		#region プロパティ

		/// <summary>
		/// 現在選択しているフォルダのパス
		/// 未選択の場合は空文字を戻します
		/// </summary>
		string CurrentFolder { get; }

		/// <summary>
		/// ウィンドウを表示しているか
		/// </summary>
		bool IsVisible {get;}

		/// <summary>
		/// ウィンドウがアクティブか
		/// </summary>
		bool IsActive {get;}

		#endregion

		#region 公開サービス

		/// <summary>
		/// 現在選択しているレビューファイルのパスを取得します
		/// </summary>
		/// <returns>選択したレビューファイルのパス一覧</returns>
		IEnumerable<string> GetSelectedReviewFilePaths();

		/// <summary>
		/// 現在選択しているレビューファイルのサマリを取得します
		/// </summary>
		/// <returns>選択したレビューのサマリ一覧</returns>
		IEnumerable<IReviewSummary> GetSelectedReviewSummaries();

		/// <summary>
		/// 現在のフォルダのレビューファイルのパス一覧を取得します
		/// </summary>
		/// <returns>レビューファイルのパス一覧</returns>
		IEnumerable<string> GetReviewFiles();

		/// <summary>
		/// 現在のフォルダのレビューのサマリ一覧を取得します
		/// </summary>
		/// <returns>レビューのサマリ一覧</returns>
		IEnumerable<IReviewSummary> GetReviewSummaries();

		/// <summary>
		/// 画面を再ロードします
		/// </summary>
		void Reload();

		#endregion
	}
}