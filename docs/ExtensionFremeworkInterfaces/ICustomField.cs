namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// カスタムフィールドの編集を実現するインターフェース。
    /// </summary>
    public interface ICustomField<TDefinition>
    {
        /// <summary>
        /// カスタムフィールドの定義を取得します。
        /// </summary>
        TDefinition Definition { get; }

        /// <summary>
        /// カスタムフィールドの値を取得します。
        /// </summary>
        /// <returns>カスタムフィールドの値。</returns>
        string GetValue();

        /// <summary>
        /// カスタムフィールドの値を設定します。
        /// </summary>
        /// <param name="value">設定する値。</param>
        void SetValue(string value);
    }
}