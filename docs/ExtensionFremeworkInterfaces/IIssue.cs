using System;
using System.Collections.Generic;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
    /// <summary>
    /// 指摘の編集を実現するインタフェースです。
    /// </summary>
    public interface IIssue : IEntityBase
    {
        #region 公開プロパティ

        /// <summary>
        /// 修正方針
        /// </summary>
        string CorrectionPolicy { get; set; }

        /// <summary>
        /// この指摘が登録されているレビュー
        /// 外部からは変更できません。
        /// </summary>
        IReviewSetting Review { get; }

        /// <summary>
        /// 対象ドキュメント
        /// </summary>
        string DocumentID { get; }

        /// <summary>
        /// 関連付けられているアウトラインノード
        /// </summary>
        IOutlineNode OutlineNode { get; set; }

        /// <summary>
        /// タイプ
        /// 本プロパティの値域と、それぞれの値に対応するタイプを以下に示します。
        ///
        /// [値域]			[値に対応するタイプ]
        /// Bug				不具合
        /// Suggestion		指摘
        /// GoodPoint		グッドポイント
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// 分類
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// 指摘理由
        /// </summary>
        string Reason { get; set; }

        /// <summary>
        /// 差し戻し理由
        /// </summary>
        string SendingBackReason { get; set; }

        /// <summary>
        /// 指摘のステータスを取得または設定(差し戻し考慮なし)します。
        /// 本プロパティの値域と、それぞれの値に対応するステータスを以下に示します。
        ///
        /// [値域]						[値に対応するステータス]
        /// NotRevised					未修正
        /// CorrectionPolicyExamined	修正方針検討済み
        /// CorrectionPolicyApproved	修正方針承認済み
        /// Revised						修正済み
        /// Confirmed					確認済み		
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// 現在差戻し中かどうかをあらわすフラグ
        /// </summary>
        bool IsSendingBack { get; set; }

        /// <summary>
        /// 過去に一度でも差し戻しがあったことを記録するフラグ
        /// </summary>
        bool HasBeenSentBack { get; set; }

        /// <summary>
        /// 差し戻すことができるか
        /// ステータスの変更に合わせてOnPropertyChangedを発行する
        /// </summary>
        bool CanSendBack { get; }

        /// <summary>
        /// 検出工程
        /// </summary>
        string DetectionActivity { get; set; }

        /// <summary>
        /// 原因工程
        /// </summary>
        string InjectionActivity { get; set; }

        /// <summary>
        /// 優先度
        /// 本プロパティの値域と、それぞれの値に対応する優先度を以下に示します。
        ///
        /// [値域]			[値に対応する優先度]
        /// Low				低
        /// Middle			中
        /// High			高
        /// </summary>
        string Priority { get; set; }

        /// <summary>
        /// 重大度
        /// 本プロパティの値域と、それぞれの値に対応する重大度を以下に示します。
        ///
        /// [値域]			[値に対応する重大度]
        /// Low				低
        /// Middle			中
        /// High			高
        /// </summary>
        string Importance { get; set; }

        /// <summary>
        /// 場所（関連付けられているアウトラインノードの名前）
        /// </summary>
        string OutlineName { get; }

        /// <summary>
        /// 場所（ルートレベルのアウトラインノードの名前）
        /// </summary>
        string RootOutlinePath { get; }

        /// <summary>
        /// 場所
        /// </summary>
        string OutlinePath { get; set; }

        /// <summary>
        /// 報告者
        /// </summary>
        string ReportedBy { get; set; }

        /// <summary>
        /// 報告日
        /// </summary>
        DateTime? DateReported { get; set; }

        /// <summary>
        /// 対策要否
        /// 本プロパティの値域と、それぞれの値に対応する対策要否を以下に示します。
        ///
        /// [値域]			[値に対応する対策要否]
        /// Yes				はい
        /// No				いいえ
        /// Suspended		保留
        /// </summary>
        string NeedToFix { get; set; }

        /// <summary>
        /// 修正者
        /// </summary>
        string AssignedTo { get; set; }

        /// <summary>
        /// 期日
        /// </summary>
        DateTime? DueDate { get; set; }

        /// <summary>
        /// 修正日
        /// </summary>
        DateTime? DateFixed { get; set; }

        /// <summary>
        /// 対策
        /// </summary>
        string Resolution { get; set; }

        /// <summary>
        /// 確認者
        /// </summary>
        string ConfirmedBy { get; set; }

        /// <summary>
        /// 確認日
        /// </summary>
        DateTime? DateConfirmed { get; set; }

        /// <summary>
        /// コメント
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// カスタムテキスト1
        /// </summary>
        [Obsolete]
        string CustomText1 { get; set; }

        /// <summary>
        /// カスタムテキスト2
        /// </summary>
        [Obsolete]
        string CustomText2 { get; set; }

        /// <summary>
        /// カスタムテキスト3
        /// </summary>
        [Obsolete]
        string CustomText3 { get; set; }

        /// <summary>
        /// カスタムテキスト4
        /// </summary>
        [Obsolete]
        string CustomText4 { get; set; }

        /// <summary>
        /// カスタムテキスト5
        /// </summary>
        [Obsolete]
        string CustomText5 { get; set; }

        /// <summary>
        /// カスタムテキスト6
        /// </summary>
        [Obsolete]
        string CustomText6 { get; set; }

        /// <summary>
        /// カスタムテキスト7
        /// </summary>
        [Obsolete]
        string CustomText7 { get; set; }

        /// <summary>
        /// カスタムテキスト8
        /// </summary>
        [Obsolete]
        string CustomText8 { get; set; }

        /// <summary>
        /// カスタムテキスト9
        /// </summary>
        [Obsolete]
        string CustomText9 { get; set; }

        /// <summary>
        /// カスタムテキスト10
        /// </summary>
        [Obsolete]
        string CustomText10 { get; set; }

        /// <summary>
        /// 指摘にフィルタがかかっているか
        /// </summary>
        bool IsFiltered { get; }

        /// <summary>
        /// 指摘画像数
        /// </summary>
        int ReportedImageCount { get; }

        /// <summary>
        /// 修正画像数
        /// </summary>
        int FixedImageCount { get; }

        /// <summary>
        /// カスタムフィールドの値を取得します。
        /// </summary>
        IEnumerable<ICustomField<ICustomFieldDefinition>> CustomFields { get; }

        /// <summary>
        /// 指摘の修正前リンクの一覧を取得します。
        /// </summary>
        /// <value>指摘の修正前リンクの一覧。</value>
        IEntityCollection<IIssueLink> NotRevisedLinks { get; }

        /// <summary>
        /// 指摘の修正後リンクの一覧を取得します。
        /// </summary>
        /// <value>指摘の修正後リンクの一覧。</value>
        IEntityCollection<IIssueLink> RevisedLinks { get; }

        #endregion

        #region 公開サービス

        /// <summary>
        /// 指摘画像を追加する
        /// </summary>
        /// <param name="filePath">画像ファイルのパス</param>
        void AddReportedImage(string filePath);

        /// <summary>
        /// 修正画像を追加する
        /// </summary>
        /// <param name="filePath">画像ファイルのパス</param>
        /// <param name="imageNumber">関連付けたい指摘画像の番号</param>
        void AddFixedImage(string filePath, int imageNumber);

        /// <summary>
        /// 指摘画像の一覧を取得する
        /// </summary>
        /// <returns>指摘画像一覧</returns>
        IEnumerable<IIssueImage> GetReportedImages();

        /// <summary>
        /// 修正画像の一覧を取得する
        /// </summary>
        /// <returns>修正画像一覧</returns>
        IEnumerable<IIssueImage> GetFixedImages();

        /// <summary>
        /// 指摘画像を削除する
        /// </summary>
        /// <param name="index">指摘画像のインデックス</param>
        void DeleteReportedImage(int index);

        /// <summary>
        /// 修正画像を削除する
        /// </summary>
        /// <param name="index">修正画像のインデックス</param>
        void DeleteFixedImage(int index);

        /// <summary>
        /// 全ての指摘画像を削除する
        /// </summary>
        void ClearAllReportedImages();

        /// <summary>
        /// 全ての修正画像を削除する
        /// </summary>
        void ClearAllFixedImages();

        #endregion
    }
}
