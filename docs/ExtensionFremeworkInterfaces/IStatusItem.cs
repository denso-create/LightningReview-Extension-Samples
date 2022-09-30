using System;

namespace LightningReview.ExtensionFramework.LightningReview;

/// <summary>
/// ステータスの編集を実現するインターフェース。
/// </summary>
public interface IStatusItem : IEntityBase
{
    #region プロパティ

    /// <summary>
    /// ステータスの名前を取得または設定します。
    /// 他の選択肢と重複していても構いませんが、空文字列にはできません。
    /// 空文字列を指定した場合は、元の値に戻します。
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// 設定日を取得または設定します。
    /// ステータスを設定した日付が自動入力されます。
    /// </summary>
    DateTime? SelectedOn { get; set; }

    /// <summary>
    /// 設定者名を取得または設定します。
    /// ステータスを設定したユーザー名が自動入力されます。
    /// </summary>
    string SelectedBy { get; set; }

    /// <summary>
    /// クローズを意味するステータスかを取得または設定します。
    /// </summary>
    bool IsClosed { get; set; }

    /// <summary>
    /// このステータスが、現在のステータスとして設定されているかを取得・設定します。
    /// この値をtrueに変更した場合、他のすべてのステータスの値はfalseになります。
    /// </summary>
    bool IsSelected { get; set; }

    /// <summary>
    /// ステータスの色を取得または設定します。デフォルトでは[None]が設定されています。
    /// </summary>
	/// <value>
    /// 色の種類の文字列。
    /// 本プロパティの値域と、それぞれの値に対応する種類を以下に示します。
    /// [値域]      [値に対応する種類]
    /// None        なし
    /// Red         赤
    /// Orange      橙
    /// Yellow      黄
    /// Green       緑
    /// Blue        青
    /// Purple      紫
    /// Gray        灰
    /// LightRed    薄い赤
    /// LightOrange 薄い橙
    /// LightYellow 薄い黄
    /// LightGreen  薄い緑
    /// LightBlue   薄い青
    /// LightPurple 薄い紫
    /// LightGray   薄い灰
    /// </value>
    /// <exception cref="UserException">値域外の文字列を設定しています。</exception>
    string Color { get; set; }

    #endregion
}