namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// メンバのカスタムロール定義の編集を実現するインタフェース。
    /// </summary>
    public interface IMemberCustomRoleDefinition : IEntityBase
    {
        #region プロパティ

        /// <summary>
        /// 表示名を取得または設定します。
        /// 他のフィールドと重複していても構いませんが、空文字列にはできません。
        /// 空文字列を指定した場合は、元の値に戻します。
        /// </summary>
        string DisplayName { get; set; }

        /// <summary>
        /// フィールドを使用するか否かを取得または設定します。
        /// </summary>
        bool Enabled { get; set; }

        #endregion
    }
}