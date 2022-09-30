namespace LightningReview.ExtensionFramework.LightningReview;

/// <summary>
/// ノートグループの編集を実現するインタフェースです。
/// </summary>
public interface INoteGroup : IEntityBase
{
    #region 公開プロパティ

    /// <summary>
    /// ノートグループ名を取得・設定します。
    /// </summary>
    /// <value>ノートグループ名の文字列。空文字のみ、スペースのみ、nullを設定した場合は、何もしません。</value>
    string Name { get; set; }

    #endregion
}