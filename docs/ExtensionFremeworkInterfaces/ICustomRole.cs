namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// カスタムロールの編集を実現するインターフェース。
    /// </summary>
    public interface ICustomRole
    {
        /// <summary>
        /// カスタムロールの定義を取得します。
        /// </summary>
        IMemberCustomRoleDefinition Definition { get; }

        /// <summary>
        /// カスタムロールに割り当てられているかを取得または設定します。
        /// </summary>
        bool IsAssigned { get; set; }
    }
}