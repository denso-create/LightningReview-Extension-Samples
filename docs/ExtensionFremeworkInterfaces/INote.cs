namespace LightningReview.ExtensionFramework.LightningReview;

/// <summary>
/// ノートの編集を実現するインタフェースです。
/// </summary>
public interface INote : IEntityBase
{
    #region 公開プロパティ

    /// <summary>
    /// ノート名を取得・設定します。
    /// </summary>
    /// <value>ノート名の文字列。空文字のみ、スペースのみ、nullを設定した場合は、何もしません。</value>
    string Name { get; set; }

    /// <summary>
    /// ノートの内容を取得・設定します。
    /// </summary>
    /// <value>ノートの内容の文字列。nullを設定した場合は、何もしません。</value>
    string Content { get; set; }

    /// <summary>
    /// ノートの内容の種類を取得・設定します。
    /// </summary>
    /// <value>
    /// ノートの内容の種類の文字列。
    /// 本プロパティの値域と、それぞれの値に対応する種類を以下に示します。
    /// [値域]      [値に対応する種類]
    /// Text        テキスト
    /// Markdown    マークダウン
    /// </value>
    /// <exception cref="UserException">値域外の文字列を設定しています。</exception>
    string ContentType { get; set; }

    /// <summary>
    /// ノートが所属するノートグループ名を取得・設定します。
    /// </summary>
    /// <remarks>
    /// 設定した名前のノートグループが複数存在する場合は、同名のノートグループのうち先頭のノートグループに所属します。
    /// </remarks>
    /// <value>
    /// ノートが所属するノートグループ名の文字列。
    /// ノートがノートグループに所属していない場合はnullです。
    /// </value>
    /// <exception cref="UserException">存在しないノートグループ名を設定しています。</exception>
    string GroupName { get; set; }

    #endregion


}