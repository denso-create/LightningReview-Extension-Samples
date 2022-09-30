using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// レビューのサマリ情報を取得するためのインターフェース
	/// </summary>
	public interface IReviewSummary
	{
		#region プロパティ

		/// <summary>
		/// レビューファイルの名前
		/// </summary>
		string FileName { get; }

		/// <summary>
		/// レビューファイルのパス
		/// </summary>
		string FilePath { get; }

		/// <summary>
		/// ステータス
		/// </summary>
		string Status { get; }

		/// <summary>
		/// 計画実施日
		/// </summary>
		DateTime? PlannedDate { get; }

		/// <summary>
		/// 実績実施日
		/// </summary>
		DateTime? ActualDate { get; }

		/// <summary>
		/// 指摘の総件数
		/// </summary>
		int AllIssueCount { get; }
		
		/// <summary>
		/// 種別が「不具合」の指摘件数
		/// </summary>
		int BugIssueCount { get; }

		/// <summary>
		/// 種別が「指摘」の指摘件数
		/// </summary>
		int SuggestionIssueCount { get; }
		
		/// <summary>
		/// 未修正の件数
		/// </summary>
		int NotRevisedIssueCount { get; }

		/// <summary>
		/// 修正済みの件数
		/// </summary>
		int RevisedIssueCount { get; }

		/// <summary>
		/// 確認済みの件数
		/// </summary>
		int ConfirmedIssueCount { get; }
		
		/// <summary>
		/// 対策不要の件数
		/// </summary>
		int NotNeedToFixIssueCount { get; }

		/// <summary>
		/// グッドポイントの件数
		/// </summary>
		int GoodPointIssueCount { get; }

		#endregion
	}
}