using System;
using System.Collections.Generic;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
    /// <summary>
    /// レビュー設定の編集を実現するインタフェース
    /// </summary>
    public interface IReviewSetting : IEntityBase
    {
        #region プロパティ

        /// <summary>
        /// メンバ情報のコレクション
        /// </summary>
        IEnumerable<IReviewMember> Members { get; }

        /// <summary>
        /// レビュー名
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// 場所
        /// </summary>
        string Place { get; set; }

        /// <summary>
        /// 目的
        /// </summary>
        string Goal { get; set; }

        /// <summary>
        /// 終了条件
        /// </summary>
        string EndCondition { get; set; }

        /// <summary>
        /// プロジェクト名
        /// </summary>
        string ProjectName { get; set; }

        /// <summary>
        /// プロジェクトコード
        /// </summary>
        string ProjectCode { get; set; }

        /// <summary>
        /// 修正方針ステータスを使用するか
        /// </summary>
        bool UseCorrectionPolicyStatus { get; set; }

        /// <summary>
        /// 修正方針を記録するか
        /// </summary>
        bool UseCorrectionPolicy { get; set; }

        /// <summary>
        /// 指摘理由を記録するか
        /// </summary>
        bool UseReason { get; set; }

        /// <summary>
        /// 計画実施日
        /// </summary>
        DateTime? PlannedDate { get; set; }

        /// <summary>
        /// 実績実施日
        /// </summary>
        DateTime? ActualDate { get; set; }

        /// <summary>
        /// 計画時間（分単位）
        /// </summary>
        double? PlannedTime { get; set; }

        /// <summary>
        /// 実績時間(分単位)
        /// </summary>
        double? ActualTime { get; set; }

        /// <summary>
        /// 成果物単位
        /// </summary>
        string Unit { get; set; }

        /// <summary>
        /// 予定規模
        /// </summary>
        double? PlannedScale { get; set; }

        /// <summary>
        /// 実績規模
        /// </summary>
        double? ActualScale { get; set; }

        /// <summary>
        /// 目標件数
        /// </summary>
        double? IssueCountOfGoal { get; set; }

        /// <summary>
        /// 実績件数
        /// </summary>
        double? IssueCountOfActual { get; }

        /// <summary>
        /// レビュー種別
        /// </summary>
        string ReviewType { get; set; }

        /// <summary>
        /// レビュー種別の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// レビュー種別の選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string ReviewTypeAllowedValues { get; set; }

        /// <summary>
        /// ドメイン
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// ドメインの選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// ドメインの選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string DomainAllowedValues { get; set; }

        /// <summary>
        /// ステータス
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// ステータスアイテムを取得または設定します。
        /// </summary>
        IStatusItem StatusItem { get; set; }


        /// <summary>
        /// ステータスの選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// ステータスの選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        [Obsolete]
        string StatusAllowedValues { get; set; }

        /// <summary>
        /// ステータスのコレクションを取得します。
        /// </summary>
        IEnumerable<IStatusItem> StatusItems { get; }

        /// <summary>
        /// レビュー形式
        /// </summary>
        string ReviewStyle { get; set; }

        /// <summary>
        /// レビュー形式の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// レビュー形式の選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string ReviewStyleAllowedValues { get; set; }

        /// <summary>
        /// 分類のデフォルト値
        /// </summary>
        string CategoryDefaultValue { get; set; }

        /// <summary>
        /// 分類の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// 分類の選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string CategoryAllowedValues { get; set; }

        /// <summary>
        /// 検出工程のデフォルト値
        /// </summary>
        string DetectionActivityDefaultValue { get; set; }

        /// <summary>
        /// 検出工程の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// 検出工程の選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string DetectionActivityAllowedValues { get; set; }

        /// <summary>
        /// 原因工程のデフォルト値
        /// </summary>
        string InjectionActivityDefaultValue { get; set; }

        /// <summary>
        /// 原因工程の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。
        /// 原因工程の選択肢のリストを改行区切りで連結した文字列を取得する。
        /// 取得・設定ともリストの並び順と一致することを保証する。
        /// 設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。
        /// 設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と
        /// 文字列中に含まれるすべての改行文字を無視する（削除する）。
        /// </summary>
        string InjectionActivityAllowedValues { get; set; }
        
        /// <summary>
        /// レビューのカスタムフィールドの値を取得します。
        /// </summary>
        IEnumerable<ICustomField<IReviewCustomFieldDefinition>> ReviewCustomFields { get; }

        /// <summary>
        /// レビューのカスタムフィールドの定義を取得します。
        /// </summary>
        IEnumerable<IReviewCustomFieldDefinition> ReviewCustomFieldDefinitions { get; }

        /// <summary>
        /// メンバのカスタムロールの定義を取得します。
        /// </summary>
        IEnumerable<IMemberCustomRoleDefinition> MemberCustomRoleDefinitions { get; }

        /// <summary>
        /// メンバのカスタムフィールドの定義を取得します。
        /// </summary>
        IEnumerable<IMemberCustomFieldDefinition> MemberCustomFieldDefinitions { get; }

        /// <summary>
        /// 指摘のカスタムフィールドの定義を取得します。
        /// </summary>
        IEnumerable<ICustomFieldDefinition> CustomFields { get; }

        #endregion

        #region 公開サービス

        /// <summary>
        /// メンバの追加
        /// </summary>
        /// <param name="memberName">メンバ名</param>
        /// <returns>追加したメンバ</returns>
        IReviewMember AddMember(string memberName);

        /// <summary>
        /// メンバの削除
        /// </summary>
        /// <param name="member">削除するメンバ</param>
        void DeleteMember(IReviewMember member);

        /// <summary>
        /// ステータスを追加します。
        /// </summary>
        /// <param name="statusName">追加対象のステータス名。</param>
        IStatusItem AddStatusItem(string statusName);

        /// <summary>
        /// ステータスを削除します。
        /// </summary>
        /// <param name="status">削除対象のスタータス。</param>
        void DeleteStatusItem(IStatusItem status);

        #endregion
    }
}