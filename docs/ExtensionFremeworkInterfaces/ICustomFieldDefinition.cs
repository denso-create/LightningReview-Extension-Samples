using System;

namespace LightningReview.ExtensionFramework.LightningReview
{
	/// <summary>
	/// 指摘のカスタムフィールド定義の編集を実現するインタフェース
	/// </summary>
	public interface ICustomFieldDefinition : IEntityBase
	{
		#region プロパティ

		/// <summary>
		/// 表示名
		/// 他のフィールドと重複していても構わないが、空文字列にはできない。
		/// 空文字列を指定した場合は、元の値に戻す。
		/// </summary>
		string DisplayName { get; set; }

		/// <summary>
		/// 選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
		/// 選択肢のリストを改行区切りで連結した文字列を取得する。
		/// 取得・設定ともリストの並び順と一致することを保証する。
		/// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
		/// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
		/// 文字列中に含まれるすべての改行文字を無視する（削除する）。
		/// </summary>
		string AllowedValues { get; set; }

		/// <summary>
		/// デフォルト値
		/// </summary>
		string DefaultValue { get; set; }

		/// <summary>
		/// フィールドを使用するか否か
		/// </summary>
		bool Enabled { get; set; }

		#endregion

	}
}
