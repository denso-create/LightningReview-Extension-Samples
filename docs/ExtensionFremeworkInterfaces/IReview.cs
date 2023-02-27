using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview
{
	/// <summary>
	/// レビューの操作を実現するインターフェースです。
	/// </summary>
	public interface IReview : IEntityBase
	{
		#region プロパティ

		/// <summary>
		/// レビューファイルの絶対パスを取得します。
		/// </summary>
		/// <value>レビューファイルの絶対パスの文字列。</value>
		string FilePath { get; }

		/// <summary>
		/// レビューファイルに関連づくドキュメントの一覧を取得します。
		/// </summary>
		/// <value>レビューファイルに関連づくドキュメントの一覧。</value>
		IEnumerable<IDocument> Documents { get; }

		/// <summary>
		/// 前回の保存時からレビューが変更されたかどうかを取得します。
		/// </summary>
		/// <value>レビューが変更されたかどうか。</value>
		bool IsDirty { get; }

		/// <summary>
		/// レビューの設定オブジェクトを取得します。
		/// </summary>
		IReviewSetting ReviewSetting { get; }

        /// <summary>
        /// レビューファイルに関連づくノートグループの一覧を取得します。
        /// </summary>
        /// <value>ノートグループの一覧。</value>
        IEnumerable<INoteGroup> NoteGroups { get; }

        /// <summary>
        /// レビューファイルに関連づくノートの一覧を取得します。
        /// </summary>
        /// <value>ノートの一覧。</value>
        IEnumerable<INote> Notes { get; }

        #endregion

        #region 公開サービス

        #region 指摘

        /// <summary>
        /// 対象のドキュメントに指摘を追加します。
        /// </summary>
        /// <param name="document">追加対象のドキュメント。</param>
        /// <returns>追加した指摘。</returns>
        IIssue AddIssue(IDocument document);

		/// <summary>
		/// 対象のドキュメントのアウトラインパスで指定したアウトラインに指摘を追加します。
		/// </summary>
		/// <param name="document">追加対象のドキュメント。</param>
		/// <param name="outlinePath">指定するアウトラインパス。</param>
		/// <returns>追加した指摘。</returns>
		IIssue AddIssue(IDocument document, string outlinePath);

		/// <summary>
		/// 対象のアウトラインに指摘を追加します。
		/// </summary>
		/// <param name="node">追加対象のアウトライン。</param>
		/// <returns>追加した指摘。</returns>
		IIssue AddIssue(IOutlineNode node);

		/// <summary>
		/// レビューファイルに関連づく指摘の一覧を取得します。
		/// </summary>
		/// <returns>取得した指摘の一覧。</returns>
		IEnumerable<IIssue> GetAllIssues();

		/// <summary>
		/// 指摘のIdを指定して指摘を取得します。
		/// </summary>
		/// <param name="issueId">指定する指摘ID。</param>
		/// <param name="globalId">指定する指摘IDの分類。グローバルIDで検索する場合はtrue、ローカルIDで検索する場合はfalseです。</param>
		/// <returns>取得した指摘。</returns>
		IIssue GetIssue(string issueId, bool globalId = false);

		/// <summary>
		/// 指摘を削除します。
		/// </summary>
		/// <param name="issue">削除する指摘。</param>
		void DeleteIssue(IIssue issue);

		/// <summary>
		/// 指摘のIdを指定して指摘を削除します。
		/// </summary>
		/// <param name="issueId">指定する指摘ID。</param>
		/// <param name="globalId">指定する指摘IDの分類。グローバルIDで削除する場合はtrue、ローカルIDで削除する場合はfalseです。</param>
		void DeleteIssueById(string issueId, bool globalId = false);

		#endregion

		#region ドキュメント 

		/// <summary>
		/// このコンテキストが保持しているレビューデータにドキュメントを追加します。
		/// </summary>
		/// <returns>追加されたドキュメント。</returns>
		IDocument AddDocument();

		/// <summary>
		/// ファイル名を指定して、新規にドキュメントを追加します。
		/// 作成したドキュメントは、このレビューのドキュメントとして登録されます。
		/// </summary>
		/// <param name="filePath">指定するファイルパス。</param>
		/// <returns>追加されたドキュメント。</returns>
		IDocument AddDocument(string filePath);

		/// <summary>
		/// 指定したファイル名のドキュメントを取得します。
		/// ファイル名の大・小文字は区別しません。
		/// </summary>
		/// <param name="filePath">指定するファイル名(絶対パス)。</param>
		/// <returns>取得したドキュメント。</returns>
		IDocument GetDocument(string filePath);

		/// <summary>
		/// 既存のドキュメントを削除します。
		/// </summary>
		/// <param name="document">削除するドキュメント。</param>
		void DeleteDocument(IDocument document);

		#endregion

        #region ノート

        /// <summary>
        /// ノートグループを追加します。
        /// </summary>
        /// <param name="name">
        /// 追加するノートグループの名前。
        /// 空文字のみ、スペースのみ、nullを指定した場合は、既定の名前で追加します。
        /// </param>
        /// <returns>追加したノートグループ。</returns>
        INoteGroup AddNoteGroup(string name);

        /// <summary>
        /// ノートグループを削除します。
        /// </summary>
        /// <param name="noteGroup">削除するノートグループ。</param>
        /// <exception cref="UserException">削除対象のノートグループが存在しません。</exception>
        void DeleteNoteGroup(INoteGroup noteGroup);

        /// <summary>
        /// ノートを追加します。
        /// ノートの内容の種類と所属するノートグループ名を指定して追加できます。
        /// </summary>
        /// <remarks>
        /// 指定した名前のノートグループが複数存在する場合は、同名のノートグループのうち先頭のノートグループに追加します。
        /// </remarks>
        /// <param name="name">
        /// 追加するノートの名前。
        /// 空文字のみ、スペースのみ、nullを指定した場合は、既定の名前で追加します。
        /// </param>
        /// <param name="contentType">
        /// 指定するノートの内容の種類。
        /// 引数の値域と、それぞれの値に対応する種類を以下に示します。
        /// [値域]      [値に対応する種類]
        /// Text        テキスト
        /// Markdown    マークダウン
        /// </param>
        /// <param name="groupName">指定するノートグループの名前。nullの場合はノートグループに属しません。</param>
        /// <returns>追加したノート。</returns>
        /// <exception cref="UserException">指定されたノートの内容の種類、またはノートグループが存在しません。</exception>
        INote AddNote(string name, string contentType = "Markdown", string groupName = null);

        /// <summary>
        /// ノートを削除します。
        /// </summary>
        /// <param name="note">削除するノート。</param>
        /// <exception cref="UserException">削除対象のノートが存在しません。</exception>
        void DeleteNote(INote note);

        #endregion

        #endregion
    }
}
