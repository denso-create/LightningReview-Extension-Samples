namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// レビューのカスタムフィールド定義の編集を実現するインターフェース。
    /// </summary>
    public interface IReviewCustomFieldDefinition : IEntityBase
    {
        #region プロパティ

        /// <summary>
        /// 表示名を取得または設定します。
        /// 他のフィールドと重複していても構わないが、空文字列にはできません。
        /// 空文字列を指定した場合は、元の値に戻します。
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// 選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定します。
        /// 選択肢のリストを改行区切りで連結した文字列を取得します。
        /// 取得・設定ともリストの並び順と一致することを保証します。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持します。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視します（削除する）。
        /// </summary>
        string AllowedValues { get; set; }

        /// <summary>
        /// フィールドを使用するか否かを取得または設定します。
        /// </summary>
        bool Enabled { get; set; }

        /// <summary>
        /// 所属するグループを取得または設定します。
        /// </summary>
        /// <value>
        /// 所属するグループ。
        /// 以下の値を設定できます。
        /// [値域]            [値に対応するグループ]
        /// General           基本設定
        /// Project           プロジェクト
        /// PlanAndActual     計画と実績 
        /// </value>
        string Group { get; set; }

        #endregion
    }
}