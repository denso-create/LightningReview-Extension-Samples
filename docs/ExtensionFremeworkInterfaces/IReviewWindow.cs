using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms.VisualStyles;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
    /// <summary>
    /// レビューウィンドウの操作を実現するインタフェース
    /// </summary>
    public interface IReviewWindow
    {
        #region プロパティ

        /// <summary>
        /// レビューの操作を実現するインターフェースを取得します。
        /// </summary>
        IReview Review { get; }

        /// <summary>
        /// スタートページは表示中であるかを取得します。
        /// </summary>
        bool IsStartPageVisible { get; }

        /// <summary>
        /// レビューウィンドウのタイトルを取得または設定します。
        /// 取得または設定できるのは、" - Lightning Review"より前の部分のタイトルです。
        /// </summary>
        string Title { get; set; }

        #endregion

        #region ウィンドウ

        /// <summary>
        /// ウィンドウをアクティブにします。
        /// </summary>
        void Activate();

        /// <summary>
        /// レビューウィンドウをWindow型で取得します。
        /// </summary>
        /// <returns>対象のWindow</returns>
        Window GetWindow();

        /// <summary>
        ///  レビューウィンドウのタイトルの設定を、本体側の設定に戻します。
        /// </summary>
        void ResetTitle();

        #endregion

        #region ファイル
        
        /// <summary>
        /// ファイルを新規作成します。
        /// 現在開いているファイルは閉じます。
        /// </summary>
        /// <param name="discard">変更を無視して閉じる場合はtrue,変更している場合に閉じない場合はfalse</param>
        void NewReview(bool discard = false);

        /// <summary>
        /// 指定したテンプレートからレビューを新規作成します。
        /// 現在開いているファイルは閉じます。
        /// </summary>
        /// <param name="templateFilePath">テンプレートのパス</param>
        /// <param name="discard">変更を無視して閉じる場合はtrue,変更している場合に閉じない場合はfalse</param>
        void NewReviewFromTemplate(string templateFilePath, bool discard = false);

        /// <summary>
        /// ファイルを指定して開きます。
        /// 現在開いているファイルは閉じます。
        /// </summary>
        /// <param name="filename"></param>
        void Open(string filename);

        /// <summary>
        /// ファイルを名前を付けて保存します。
        /// </summary>
        /// <param name="filename"></param>
        void SaveAs(string filename);

        /// <summary>
        /// ファイルを上書き保存します。
        /// </summary>
        void Save();

        /// <summary>
        /// ウィンドウを閉じます。
        /// </summary>
        /// <param name="discard">変更を無視して閉じる場合はtrue,変更している場合に閉じない場合はfalseを返します。</param>
        /// <returns>閉じたか</returns>
        bool Close(bool discard = false);
        
        #endregion

        #region 編集制御

        /// <summary>
        /// 編集の開始を指定します。
        /// （特に指定しなくても編集は可能であるがアンドゥの単位を指定できます）
        /// 必ずusingで囲ってください。
        /// </summary>
        /// <param name="autoCommit">トランザクションのDispose時に自動でコミットするか。
        /// trueの場合は自動でコミットします。
        /// falseの場合は戻り値のトランザクションを用いてCommit()を呼び出す必要があり、Commit()を呼び出さずにDisposeした場合は自動でRollBack()を呼び出します。</param>
        /// <returns>トランザクション</returns>
        IUndoTransaction BeginEdit(bool autoCommit = true);

        /// <summary>
        /// テキストボックスでの編集または画像の編集時に、その編集状態を確定します
        /// </summary>
        void CompleteEditing();

        /// <summary>
        /// 編集履歴をクリアし、レビューを未編集の状態にします。
        /// </summary>
        void ClearDirty();

        #endregion

        #region 指摘

        /// <summary>
        /// 選択した指摘を取得します。
        /// </summary>
        /// <returns>指摘</returns>
        IEnumerable<IIssue> GetSelectedIssues();

        /// <summary>
        /// 指摘を選択します。
        /// </summary>
        /// <param name="issues">選択したい指摘のリスト</param>
        void SelectIssues(IEnumerable<IIssue> issues);

        /// <summary>
        /// 指摘のIdを指定して詳細ウィンドウを表示します。
        /// </summary>
        /// <param name="issueId">対象となる指摘のId</param>
        /// <param name="globalId">GIDの場合はtrue,ローカルIdの場合はfalse</param>
        void ShowIssueDetailById(string issueId, bool globalId = false);

        /// <summary>
        /// 指摘Idでフィルタします。
        /// </summary>
        /// <param name="issueIds">対象となるIdのカンマ区切りの文字列で</param>
        void ApplyIdFilter(string issueIds);

        #endregion

        #region ドキュメント 

        /// <summary>
        /// レビューウィンドウで選択されているドキュメントの一覧を戻します。
        /// </summary>
        /// <returns>
        /// 選択されているドキュメントの一覧
        /// </returns>
        IEnumerable<IDocument> GetSelectedDocuments();

        #endregion

        #region アウトライン

        /// <summary>
        /// レビューウィンドウで選択されているアウトラインツリーのアウトラインの一覧を戻します。
        /// ドキュメントが選択されている場合、ドキュメントのルートノードを返します。
        /// </summary>
        /// <returns>
        /// 選択されているアウトラインの一覧
        /// 複数のドキュメントや親子階層で複数要素が選択されていてもそれらをすべて戻します。
        /// </returns>
        IEnumerable<IOutlineNode> GetSelectedNodes();

        /// <summary>
        /// アウトラインツリーのアウトラインを選択します。
        /// ドキュメントを選択する場合、ドキュメントのルートノードを引数として渡してください。
        /// </summary>
        /// <param name="outlineNodes">選択したいアウトラインの一覧</param>
        void SelectOutlineNodes(IEnumerable<IOutlineNode> outlineNodes);

        #endregion

        #region アウトライン解析

        /// <summary>
        /// 指定したドキュメントの先頭のリンクでアウトライン解析します。
        /// </summary>
        /// <param name="document">ドキュメント。</param>
        void ParseDocument(IDocument document);

        #endregion
    }
}