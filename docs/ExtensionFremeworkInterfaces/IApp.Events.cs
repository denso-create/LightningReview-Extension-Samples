using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// アプリケーション操作のインタフェース内のイベント定義
	/// </summary>
	public partial interface IApp
	{
		#region イベント発生制御

		/// <summary>
		/// イベントの発生を一時的に抑制できます。
		/// イベントのハンドラで編集APIを呼び出した結果、イベントが再帰的に発生して無限ループになってしまう事を抑制できます。
		/// 例えば、指摘の編集イベントを追加し、そのイベントで指摘を編集すると編集イベントが再度発生します。
		/// これを抑制するために、一時的に編集イベント内でSusupendEventを呼び出すことですべてのイベント発生を抑制できます。
		/// </summary>
		/// <returns></returns>
		/// <remarks>必ずusingで囲い、確実にサスペンドを解除するようにして下さい</remarks>
		IDisposable SuspendEvent();

		#endregion

		#region アプリケーション
		/// <summary>
		/// アプリケーションの起動が完了したときに発生します
		/// </summary>
		event Action<object, EventArgs> Startup;

		/// <summary>
		/// アプリケーションの終了前には発生します。
		/// </summary>
		event Action<object, CancelEventArgs> BeforeQuit;
		#endregion

		#region レビュー

		/// <summary>
		/// レビューを新規作成すると発生します
		/// </summary>
		event Action<object, ReviewEventArgs> ReviewNew;

		/// <summary>
		/// レビューを開く前に発生します。
		/// </summary>
		event Action<object, ReviewBeforeOpenEventArgs> ReviewBeforeOpen;

		/// <summary>
		/// レビューを開く処理の開始時に発生します。
		/// </summary>
		/// <remarks>
		/// 独自のファイルの読み込み処理を実装する場合は、このイベントのイベントハンドラで実装してください。
		/// ReviewOnOpenEventArgs.Handledプロパティをtrueにすると、開く処理を上書きできます。
		/// </remarks>
		event Action<object, ReviewOnOpenEventArgs> ReviewOnOpen;

		/// <summary>
		/// レビューを開いた後に発生します。
		/// </summary>
		event Action<object, ReviewEventArgs> ReviewAfterOpen;

		/// <summary>
		/// レビューの保存前に発生します。
		/// </summary>
		event Action<object, ReviewCancelEventArgs> ReviewBeforeSave;

		/// <summary>
		/// レビューの保存開始時に発生します。
		/// </summary>
		/// <remarks>
		/// 独自の保存処理を実装する場合は、このイベントのイベントハンドラで実装してください。
		/// ReviewOnSaveEventArgs.Handledプロパティをtrueにすると、保存処理を上書きできます。
		/// </remarks>
		event Action<object, ReviewOnSaveEventArgs> ReviewOnSave;

		/// <summary>
		/// レビューの保存後に発生します。
		/// </summary>
		event Action<object, ReviewEventArgs> ReviewAfterSave;

		/// <summary>
		/// レビューが閉じる前に発生します。
		/// </summary>
		event Action<object, ReviewCancelEventArgs> ReviewBeforeClose;

		/// <summary>
		/// レビューが閉じた後に発生します。
		/// </summary>
		event Action<object, ReviewAfterCloseEventArgs> ReviewAfterClose;

		/// <summary>
		/// 指摘の選択が変更された時に発生します
		/// </summary>
		event Action<object, IssueEventArgs> IssueSelectionChanged;

		/// <summary>
		/// 指摘が新規作成されたときに発生します
		/// </summary>
		event Action<object, IssueEventArgs> IssueNew;

		/// <summary>
		/// 指摘の属性が編集されたときに発生します
		/// </summary>
		event Action<object, IssueEventArgs> IssueEdit;

		/// <summary>
		/// 指摘が削除される前に発生します
		/// </summary>
		event Action<object, IssueCancelEventArgs> IssueBeforeDelete;

		/// <summary>
		/// ドキュメントのアウトライン解析の前に発生します。
		/// </summary>
		event Action<object, DocumentBeforeParseEventArgs> DocumentBeforeParse;

		/// <summary>
		/// ドキュメントへのジャンプの前に発生します。
		/// </summary>
		event Action<object, DocumentBeforeJumpEventArgs> DocumentBeforeJump;

		/// <summary>
		/// アウトラインノードへのジャンプの前に発生します。
		/// </summary>
		event Action<object, OutlineNodeBeforeJumpEventArgs> OutlineNodeBeforeJump;

		/// <summary>
		/// 指摘箇所へのジャンプの前に発生します。
		/// </summary>
		event Action<object, IssueLocationBeforeJumpEventArgs> IssueLocationBeforeJump;

		/// <summary>
		/// 指摘リンクへのジャンプの前に発生します。
		/// </summary>
		event Action<object, IssueLinkBeforeJumpEventArgs> IssueLinkBeforeJump;

		#endregion

	}
}