using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using LightningReview.ExtensionFramework.LightningReview;
using LightningReview.ExtensionFramework.LightningReview.Host;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// アプリケーションの操作を実現するインタフェース
	/// </summary>
	public partial interface IApp : IHostApp
	{
		#region レビューウィンドウ

		/// <summary>
		/// すべてのレビューウインドウを取得します。
		/// </summary>
		IEnumerable<IReviewWindow> ReviewWindows { get; }

		/// <summary>
		/// アクティブなレビューウインドウを取得します。
		/// </summary>
		IReviewWindow ActiveReviewWindow { get; }

		/// <summary>
		/// 新しいレビューウインドウを新規作成します。
		/// </summary>
		/// <returns></returns>
		IReviewWindow NewReviewWindow();

		/// <summary>
		/// 新しいレビューウィンドウで、指定したレビューファイルを開きます。
		/// </summary>
		/// <param name="filename">開くレビューファイル名</param>
		/// <returns>指定したレビューファイルを開いたレビューウィンドウ</returns>
		IReviewWindow GetReviewWindowByFileName(string filename);

		/// <summary>
		/// 全てのレビューウインドウを閉じます。
		/// </summary>
		void CloseAllReviewWindows();

		#endregion

		#region レビューエクスプローラー

		/// <summary>
		/// レビューエクスプローラを取得します。
		/// </summary>
		IReviewExplorer ReviewExplorer { get; }

		/// <summary>
		/// レビューエクスプローラを表示します。
		/// </summary>
		void ShowReviewExplorer();

		#endregion

		#region ドキュメントパーサ

		/// <summary>
		/// ドキュメントパーサを登録
		/// </summary>
		/// <typeparam name="T">対象のパーサクラス</typeparam>
		void RegisterDocumentParser<T>() where T : IDocumentParser;

		/// <summary>
		/// ドキュメントパーサを削除
		/// </summary>
		/// <typeparam name="T">対象のパーサクラス</typeparam>
		void RemoveDocumentParser<T>() where T : IDocumentParser;

		#endregion

		#region App機能とプロパティ

		/// <summary>
		/// アプリケーションのバージョンを戻します。
		/// "1.7.0.0"のような文字列となります。
		/// </summary>
		string Version { get; }

		/// <summary>
		/// アプリケーションの現在のユーザ名を戻します。
		/// </summary>
		string UserName { get; set; }

		/// <summary>
		/// アプリケーションの現在のテーマを取得します。
		/// "Black","Silver"があります。
		/// </summary>
		string Theme{ get; }

		/// <summary>
		/// アクティブなレビューウインドウを閉じます 
		/// </summary>
		/// <param name="discard">開いているファイルの変更を破棄して終了します</param>
		/// <returns>Cancelされるとfalseが戻ります</returns>
		bool Quit(bool discard = true);

		/// <summary>
		/// アプリケーションを終了して再起動します
		/// </summary>
		/// <param name="discard">開いているファイルの変更を破棄して終了します</param>
		/// <returns>Cancelされるとfalseが戻ります</returns>
		bool Restart(bool discard = true);

		#endregion

		#region サービス

		/// <summary>
		/// レビューファイルをReviewWindowを伴わずに編集を実現するサービスを取得します
		/// </summary>
		/// <returns></returns>
		IReviewFileService GetReviewFileService();

        #endregion

        #region スクリプトエンジン

        /// <summary>
        /// スクリプトを実行します。
        /// </summary>
        /// <param name="filePath">スクリプトファイルのパス。</param>
        /// <param name="scriptParams">スクリプトパラメータ。</param>
        /// <returns>スクリプト実行結果。</returns>
        RunScriptResult RunScriptFile(string filePath, IDictionary<string, object> scriptParams = null);

        #endregion

        #region 開発支援

        /// <summary>
        /// ユーザーが情報収集に同意している場合に限り、指定した引数の値でサーバーにログを登録する
        /// </summary>
        /// <param name="name">ログ名</param>
        /// <param name="properties">ログのパラメータ</param>
        void TrackEvent(string name, IDictionary<string, string> properties = null);

		#endregion
	}
}