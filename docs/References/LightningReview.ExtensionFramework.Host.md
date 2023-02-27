## `AppBase`

ホストするLRのAppのベースクラス
```csharp
public abstract class LightningReview.ExtensionFramework.Host.AppBase
    : ExtensionAppBase, IHostApp, IApp

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IReviewWindow` | ActiveReviewWindow |  | 
| `DocumentParserManager` | DocumentParserManager |  | 
| `IReviewExplorer` | ReviewExplorer |  | 
| `IEnumerable<IReviewWindow>` | ReviewWindows |  | 
| `String` | Theme |  | 
| `String` | UserName |  | 
| `String` | Version |  | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `Action<Object, CancelEventArgs>` | BeforeQuit |  | 
| `Action<Object, DocumentBeforeJumpEventArgs>` | DocumentBeforeJump |  | 
| `Action<Object, DocumentBeforeParseEventArgs>` | DocumentBeforeParse |  | 
| `Action<Object, IssueCancelEventArgs>` | IssueBeforeDelete |  | 
| `Action<Object, IssueEventArgs>` | IssueEdit |  | 
| `Action<Object, IssueLinkBeforeJumpEventArgs>` | IssueLinkBeforeJump |  | 
| `Action<Object, IssueLocationBeforeJumpEventArgs>` | IssueLocationBeforeJump |  | 
| `Action<Object, IssueEventArgs>` | IssueNew |  | 
| `Action<Object, IssueEventArgs>` | IssueSelectionChanged |  | 
| `Action<Object, OutlineNodeBeforeJumpEventArgs>` | OutlineNodeBeforeJump |  | 
| `Action<Object, ReviewAfterCloseEventArgs>` | ReviewAfterClose |  | 
| `Action<Object, ReviewEventArgs>` | ReviewAfterOpen |  | 
| `Action<Object, ReviewEventArgs>` | ReviewAfterSave |  | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeClose |  | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeOpen |  | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeSave |  | 
| `Action<Object, ReviewEventArgs>` | ReviewNew |  | 
| `Action<Object, ReviewOnOpenEventArgs>` | ReviewOnOpen |  | 
| `Action<Object, ReviewOnSaveEventArgs>` | ReviewOnSave |  | 
| `Action<Object, EventArgs>` | Startup |  | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | CloseAllReviewWindows() |  | 
| `IDocumentParser` | GetDocumentParser(`String` filePath) | ドキュメントに対応するパーサを取得する | 
| `IDocumentParser` | GetDocumentParser(`IDocument` document) | ドキュメントに対応するパーサを取得する | 
| `IEnumerable<String>` | GetLogs() |  | 
| `IReviewFileService` | GetReviewFileService() |  | 
| `IReviewWindow` | GetReviewWindowByFileName(`String` filename) |  | 
| `IReviewWindow` | NewReviewWindow() |  | 
| `Boolean` | Quit(`Boolean` discard = True) |  | 
| `void` | RaiseBeforeQuit(`Object` sender, `CancelEventArgs` args) | アプリケーションの終了前イベントを発行する | 
| `void` | RaiseDocumentBeforeJump(`Object` sender, `DocumentBeforeJumpEventArgs` args) | ドキュメントにジャンプする前のイベントを発行する | 
| `void` | RaiseDocumentBeforeParse(`Object` sender, `DocumentBeforeParseEventArgs` args) | ドキュメントのアウトライン解析をする前のイベントを発行する | 
| `void` | RaiseIssueBeforeDelete(`Object` sender, `IssueCancelEventArgs` args) | 指摘が削除される前のイベントを発行する | 
| `void` | RaiseIssueEdit(`Object` sender, `IssueEventArgs` args) | 指摘の属性が編集された時のイベントを発行する | 
| `void` | RaiseIssueLinkBeforeJump(`Object` sender, `IssueLinkBeforeJumpEventArgs` args) | 指摘リンクにジャンプする前のイベントを発行する | 
| `void` | RaiseIssueLocationBeforeJump(`Object` sender, `IssueLocationBeforeJumpEventArgs` args) | 指摘箇所にジャンプする前のイベントを発行する | 
| `void` | RaiseIssueNew(`Object` sender, `IssueEventArgs` args) | 指摘が新規作成された時のイベントを発行する | 
| `void` | RaiseIssueSelectionChanged(`Object` sender, `IssueEventArgs` args) | 指摘の選択が変更された時のイベントを発行する | 
| `void` | RaiseOutlineNodeBeforeJump(`Object` sender, `OutlineNodeBeforeJumpEventArgs` args) | アウトラインにジャンプする前のイベントを発行する | 
| `void` | RaiseReviewAfterClose(`Object` sender, `ReviewAfterCloseEventArgs` args) | レビューが閉じた後のイベントを発行する | 
| `void` | RaiseReviewAfterOpen(`Object` sender, `ReviewEventArgs` args) | レビューを開く処理の開始時のイベントを発行する | 
| `void` | RaiseReviewAfterSave(`Object` sender, `ReviewEventArgs` args) | レビューの保存後イベントを発行する | 
| `void` | RaiseReviewBeforeClose(`Object` sender, `ReviewCancelEventArgs` args) | レビューが閉じる前のイベントを発行する | 
| `void` | RaiseReviewBeforeOpen(`Object` sender, `ReviewCancelEventArgs` args) | レビューを開く前のイベントを発行する | 
| `void` | RaiseReviewBeforeSave(`Object` sender, `ReviewCancelEventArgs` args) | レビューの保存前イベントを発行する | 
| `void` | RaiseReviewNew(`Object` sender, `ReviewEventArgs` args) | レビューを新規作成のイベントを発行する | 
| `void` | RaiseReviewOnOpen(`Object` sender, `ReviewOnOpenEventArgs` args) | レビューを開く処理の開始時のイベントを発行する | 
| `void` | RaiseReviewOnSave(`Object` sender, `ReviewOnSaveEventArgs` args) | レビューの保存開始イベントを発行する | 
| `void` | RaiseStartup(`Object` sender, `EventArgs` args) | アプリケーションの起動完了時のイベントを発行する | 
| `void` | RegisterDocumentParser() | パーサーを登録する | 
| `void` | RemoveDocumentParser() | パーサーを削除する | 
| `Boolean` | Restart(`Boolean` discard = True) |  | 
| `RunScriptResult` | RunScriptFile(`String` filePath, `IDictionary<String, Object>` scriptParams = null) |  | 
| `void` | ShowReviewExplorer() |  | 
| `void` | TraceLog(`String` message, `Boolean` forceWriteToFile = False) |  | 
| `void` | TrackEvent(`String` name, `IDictionary<String, String>` properties = null) |  | 


## `DocumentParserManager`

ドキュメントパーサーの管理クラス  パーサーの登録・取得・削除を行う
```csharp
public class LightningReview.ExtensionFramework.Host.DocumentParserManager

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IApp` | App | アプリケーション | 
| `IList<IDocumentParser>` | Parsers | 登録されたパーサー | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IDocumentParser` | GetParser(`String` filePath) | ファイルのパスに対応したパーサを取得する。  なければnullが戻る | 
| `IDocumentParser` | GetParser(`IDocument` document) | ファイルのパスに対応したパーサを取得する。  なければnullが戻る | 
| `void` | RegisterParser(`IDocumentParser` parser) | パーサを登録する | 
| `void` | RegisterParser() | パーサを登録する | 
| `void` | RemoveParser(`IDocumentParser` parser) | パーサを登録解除する | 
| `void` | RemoveParser() | パーサを登録解除する | 


## `ExtensionAppBase`

IAppBase実装のベースクラス
```csharp
public abstract class LightningReview.ExtensionFramework.Host.ExtensionAppBase
    : IHostApp

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IList<String>` | ExtensionFolders | エクステンションをロードするフォルダ | 
| `ExtensionManager` | ExtensionManager |  | 
| `Boolean` | IsLoaded | 読み込まれたか | 
| `MenuManager` | MenuManager | メニューマネージャー | 
| `IEnumerable<RemoveMenuInfo>` | RemoveMenuInfos | 削除するメニュー情報一覧 | 
| `ToolBarItemManager` | ToolBarItemManager | ツールバーに追加するアイテムを管理するマネージャー | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | BindUI(`String` location, `UIElement` element, `Menu` menuUI) | メニューをUIにバインドする | 
| `void` | BindUI(`String` location, `UIElement` element, `ContextMenu` menuUI) | メニューをUIにバインドする | 
| `void` | BindUI(`String` location, `UIElement` element, `ToolBar` toolBar) | メニューをUIにバインドする | 
| `Exception` | LoadExtensions() |  | 
| `void` | RegisterAfterLoadedAction(`Action` action) | 拡張機能読み込み後のアクションを登録する。  既に拡張機能が読み込み済みであれば即時実行します。 | 
| `MenuBuilder` | RegisterMenu(`IExtensionBase` Extension) | メニューのビルダーを戻します。 | 
| `ToolBarItemBuilder` | RegisterToolBarItem(`IExtensionBase` Extension) | ツールバーに追加するアイテムのビルダーを戻します。 | 
| `void` | RemoveMenu(`String` location, `String` menuName, `String` parentMenuName = ) | ロケーションと親メニュー名を指定して、指定した名前のメニューを削除します。  親メニュー名の指定がない場合は、ロケーションに対応するメニューから指定した名前のメニューを削除します。 | 
| `IDisposable` | SuspendEvent() |  | 
| `void` | UnloadExtensions() |  | 


## `ExtensionManager`

```csharp
public class LightningReview.ExtensionFramework.Host.ExtensionManager

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | App | ホストとなるアプリケーション | 
| `Boolean` | IsLoaded | エクステンションの読み込みが完了したか | 
| `IList<IExtensionBase>` | LoadedExtensions | アクティベート済みのエクステンション | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Exception` | LoadExtensions() | エクステンションを全て読みこんで、[Import]がついているプロパティに格納する。 | 
| `void` | RegisterAfterLoadedAction(`Action` action) | 拡張機能読み込み後のアクションを登録する。  既に拡張機能が読み込み済みであれば即時実行します。 | 
| `void` | UnloadExtensions() | アクティベート済みのエクステンションをディアクティベートする | 


## `MenuManager`

メニュー情報(Menuクラス)を登録したりUIにバインドするクラス
```csharp
public class LightningReview.ExtensionFramework.Host.MenuManager

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | App | アプリケーション | 
| `IDictionary<String, Menu>` | Menus | エクステンション側から追加するメニューにとって、追加先となるメニュー(アプリケーションに元々存在するメニュー)情報の一覧  keyはロケーションで、Valueは、メニュー情報である。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | BindUI(`String` location, `UIElement` element, `Menu` menuUI) | メニューをUIにバインドする | 
| `void` | BindUI(`String` location, `UIElement` element, `ContextMenu` menuUI) | メニューをUIにバインドする | 
| `Menu` | GetMenu(`String` location) | locationのメニューを取得する | 
| `Boolean` | IsValidLocation(`String` location) | 有効なロケーションか返す | 
| `void` | RegisterLocation(`String` location) | 有効なロケーションを登録する | 
| `MenuBuilder` | RegisterMenu(`MenuManager` menuManager, `IHostApp` app, `IExtensionBase` extension) | メニューのビルダーを作成する | 


