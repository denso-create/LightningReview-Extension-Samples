using System;
using System.Collections.Generic;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// レビューメンバの編集を実現するインタフェース。
	/// </summary>
	public interface IReviewMember : IEntityBase
	{
		#region プロパティ

		/// <summary>
		/// メンバーの名前
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// メンバーはレビューワか
		/// </summary>
		bool Reviewer { get; set; }

		/// <summary>
		/// メンバーはレビューイか
		/// </summary>
		bool Reviewee { get; set; }

		/// <summary>
		/// メンバーは確認者か
		/// </summary>
		bool Moderator { get; set; }

		/// <summary>
		/// カスタムロールの値を取得します。
		/// </summary>
		IEnumerable<ICustomRole> CustomRoles { get; }

		/// <summary>
		/// カスタムフィールドの値を取得します。
		/// </summary>
		IEnumerable<ICustomField<IMemberCustomFieldDefinition>> CustomFields { get; }

		/// <summary>
		/// UI非表示な情報をタグとして取得または設定します。
		/// </summary>
		string Tag { get; set; }

		#endregion
	}
}