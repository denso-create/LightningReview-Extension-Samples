## `BindableBase`

バインドするデータの基底クラス
```csharp
public class LightningReview.ExtensionFramework.BindableBase
    : INotifyPropertyChanged

```

Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `PropertyChangedEventHandler` | PropertyChanged | プロパティ変更イベント | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | NotifyChanged() | 変更を通知する | 
| `void` | OnPropertyChanged(`String` propertyName = null) | プロパティ変更イベントを発行する | 
| `Boolean` | SetProperty(`T&` storage, `T` value, `String` propertyName = ) | プロパティを設定する | 


## `DelegateCommand`

```csharp
public class LightningReview.ExtensionFramework.DelegateCommand
    : ICommand

```

Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `EventHandler` | CanExecuteChanged |  | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | CanExecute(`Object` parameter) |  | 
| `void` | Execute(`Object` parameter) |  | 


## `DocumentBeforeJumpEventArgs`

ドキュメントへのジャンプの前イベントのイベントパラメータです。
```csharp
public class LightningReview.ExtensionFramework.DocumentBeforeJumpEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IDocument` | Document | ジャンプ対象のドキュメントを取得します。 | 
| `String` | DocumentLinkName | ジャンプ対象のドキュメントリンクの名前を取得します。 | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得します。 | 
| `String` | TargetJumpPath | ジャンプ対象となるパスを取得または設定します。 | 


## `DocumentBeforeParseEventArgs`

ドキュメントのアウトライン解析の前イベントのイベントパラメータです。
```csharp
public class LightningReview.ExtensionFramework.DocumentBeforeParseEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IDocument` | Document | アウトライン解析の対象のドキュメントを取得します。 | 
| `String` | DocumentLinkName | ジャンプ対象のドキュメントリンクの名前を取得します。 | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得または設定します。 | 
| `String` | TargetParsingPath | アウトライン解析対象のパスを取得または設定します。 | 


## `DocumentParser`

ドキュメントのアウトライン解析クラス  このクラスを派生してエクステンションで登録すれば、独自のパーサーが開発できます。  docxのようにLightning Reviewがすでに対応しているアウトライン解析も置き換えることができます。
```csharp
public abstract class LightningReview.ExtensionFramework.DocumentParser
    : IDocumentParser

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<String>` | FileExtensions | パーサーが対応している拡張子の一覧を取得します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | AddFileExtension(`String` extension) | 対応した拡張子を追加します。 | 
| `Boolean` | IsFileExtensionSupported(`String` ext) | 指定の拡張子のファイルに対応したパーサーかを検証します。 | 
| `Boolean` | IsParserFor(`String` filePath) | パーサーが指定したファイルの拡張子に対応しているかを検証します。 | 
| `Boolean` | Jump(`IDocument` document, `String` physicalLocationXml, `String` filePath = ) | ドキュメントの該当位置にジャンプします。 | 
| `Boolean` | Parse(`IDocument` document, `String` filePath = ) | ドキュメントをアウトライン解析します。 | 


## `DocumentParserExportAttribute`

エクステンションとしてExportするための属性
```csharp
public class LightningReview.ExtensionFramework.DocumentParserExportAttribute
    : ExportAttribute, _Attribute, IDocumentParserMetadata

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | EnglishLabel |  | 
| `String` | Label | ドキュメントパーサの表示名 | 


## `Extension`

Lightning Reviewのエクステンション
```csharp
public abstract class LightningReview.ExtensionFramework.Extension
    : ExtensionBase, IExtensionBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IApp` | App |  | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | OnBeforeActivate() |  | 
| `void` | RegisterDocumentParser() | パーサの登録 | 
| `void` | RemoveDocumentParser() | パーサの解除 | 


## `ExtensionBase`

エクステンションの実装クラス
```csharp
public abstract class LightningReview.ExtensionFramework.ExtensionBase
    : IExtensionBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | AppBase | アプリケーション | 
| `Boolean` | Deactivated | 非アクティブ化したか | 
| `String` | Id | エクステンションのId | 
| `String` | InstallFolder | エクステンションがインストールされているフォルダ | 
| `String` | Name | エクステンションの名前 | 
| `IExtensionSettings` | Settings | エクステンションの設定を保存・復元します  エクステンションのインストールフォルダにsettings.jsonを作成します。 | 
| `String` | SettingsFolder | エクステンションの設定の格納先フォルダ | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Activate(`IHostApp` app) | エクステンションをアクティブ化します。 | 
| `void` | Deactivate() | エクステンションを非アクティブ化します。 | 
| `void` | OnActivate() | エクステンションがアクティブ化した時に実行します  メニューの追加などの初期化コードを実装してください | 
| `void` | OnBeforeActivate() | エクステンションをアクティブ化する前に実行します | 
| `void` | OnBeforeDeactivate() | エクステンションを非アクティブ化する前に実行します | 
| `void` | OnDeactivate() | エクステンションが終了する前に実行します | 
| `MenuBuilder` | RegisterMenu() | メニューの登録を開始します。MenuBuilderオブジェクトを戻すのでそこで .Location(..)のように指定して下さい。 | 
| `ToolBarItemBuilder` | RegisterToolBarItem() | ツールバーに追加するアイテムの登録を開始します。ToolBarItemBuilderオブジェクトを戻すのでそこで .Location(..)のように指定して下さい。 | 
| `void` | RemoveMenu(`String` location, `String` menuName, `String` parentMenuName = ) | ロケーションと親メニュー名を指定して、指定した名前のメニューを削除します。  親メニュー名の指定がない場合は、ロケーションに対応するメニューから指定した名前のメニューを削除します。 | 


## `ExtensionCommand`

```csharp
public abstract class LightningReview.ExtensionFramework.ExtensionCommand
    : ExtensionCommandBase, IExtensionObject, IExtensionCommandBase, ICommand

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IApp` | App |  | 


## `ExtensionCommandBase`

エクステンションのコマンドのベースクラス
```csharp
public abstract class LightningReview.ExtensionFramework.ExtensionCommandBase
    : ExtensionObject, IExtensionObject, IExtensionCommandBase, ICommand

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Description | コマンドの説明 | 
| `String` | IconResourceName | アイコンのリソース名 | 
| `Key` | Key | ショートカットキー | 
| `ModifierKeys` | Modifiers | ショートカットの修飾キー | 
| `String` | ResourceFileFullName | アイコンのリソースファイルの完全修飾名(拡張子は除く)。  通常は使わないが、dotNet Coreへの拡張性を高めるために用意している。  (dotNet CoreとdotNet Frameworkはリソースファイルのデフォルトパスが異なる。)  例：'MyApplication.MyResource.Resources.resx' というリソース ファイルの場合は 'MyResource.Resources'となる。  未設定の場合は、'[エクステンションのアセンブリ名].Properties.Resources'となる。 | 
| `String` | Shortcut | ショートカットの表示文字列 | 
| `String` | Title | コマンド名(メニュー名) | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `EventHandler` | CanExecuteChanged | 実行できるかどうかの状態変更後イベント | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | CanExecute(`Object` parameter) | 実行可能か | 
| `void` | Execute(`Object` parameter = null) | コマンドの実行は例外でハンドリング | 
| `Image` | GetIconImage() | アイコンのイメージを取得する | 
| `Boolean` | OnCanExecute(`Object` parameter) | 実行できるか | 
| `void` | OnExecute(`Object` parameter = null) | コマンドの実行 | 


Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IExtensionCommandBase` | CreateCommand(`IHostApp` app, `IExtensionBase` Extension, `Type` commandType) | コマンド作成 | 


## `ExtensionDebug`

```csharp
public class LightningReview.ExtensionFramework.ExtensionDebug

```

Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Assert(`Boolean` check, `String` message = , `IExtensionBase` extension = null) |  | 


## `ExtensionExportAttribute`

エクステンションとしてExportするための属性
```csharp
public class LightningReview.ExtensionFramework.ExtensionExportAttribute
    : ExportAttribute, _Attribute, IExtensionMetadata

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | EnglishLabel | エクステンションの表示名  （言語が英語の場合の表示名） | 
| `String` | Id |  | 
| `String` | Label | エクステンションの表示名 | 
| `String` | MinAppVersion | エクステンションを必須のアプリケーションバージョン  "1.7.0.0"のように記述する | 


## `ExtensionFrameworkServiceLocator`

DI管理。対象となるインターフェースに対するインスタンスを管理する
```csharp
public static class LightningReview.ExtensionFramework.ExtensionFrameworkServiceLocator

```

Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Register(`Object` value) | インターフェースと対応するインスタンスを登録 | 
| `void` | RegisterDefault(`Object` value) | 規定のインターフェースと対応するインスタンスを登録する  登録がなければ規定のクラスを利用するようになっていて、それをテスト時などに切り替えることができる | 
| `void` | RegisterDefaults() | Implのベースを登録 | 
| `TKey` | Resolve() | 対象となるインターフェースのインスタンスを取得する | 
| `TKey` | ResolveDefault() | デフォルトで登録されているインターフェースのインスタンスを取得する | 


## `ExtensionFrameworkSettings`

エクステンションの動作設定
```csharp
public static class LightningReview.ExtensionFramework.ExtensionFrameworkSettings

```

Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AppLocalFolderExtensionPath | AppData/Localにあるエクステンションのフォルダ | 
| `String` | ExeExtensionFolderName | exeにあるエクステンションのフォルダ | 
| `Boolean` | SupportAppLocalFolder | AppDataにあるエクステンションのフォルダをサポートするか | 
| `Boolean` | SupportExeFolder | 実行フォルダにあるエクステンションをサポートするか | 
| `Boolean` | SupportPackageFolder | 拡張機能でインストールしたパッケージのエクステンションのフォルダを対象にするか | 


Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<String>` | GetExtensionFolders() | エクステンションのフォルダ | 


## `ExtensionObject`

エクステンションのエクステンション、コマンドなどのクラスのベース
```csharp
public abstract class LightningReview.ExtensionFramework.ExtensionObject
    : IExtensionObject

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | AppBase |  | 
| `IExtensionBase` | Extension |  | 


## `ExtensionRuntimeException`

```csharp
public class LightningReview.ExtensionFramework.ExtensionRuntimeException
    : Exception, ISerializable, _Exception

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IExtensionBase` | Extension |  | 


## `IApp`

アプリケーション操作のインタフェース内のイベント定義
```csharp
public interface LightningReview.ExtensionFramework.IApp
    : IHostApp

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IReviewWindow` | ActiveReviewWindow | アクティブなレビューウインドウを取得します。 | 
| `IReviewExplorer` | ReviewExplorer | レビューエクスプローラを取得します。 | 
| `IEnumerable<IReviewWindow>` | ReviewWindows | すべてのレビューウインドウを取得します。 | 
| `String` | Theme | アプリケーションの現在のテーマを取得します。  "Black","Silver"があります。 | 
| `String` | UserName | アプリケーションの現在のユーザ名を戻します。 | 
| `String` | Version | アプリケーションのバージョンを戻します。  "1.7.0.0"のような文字列となります。 | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `Action<Object, CancelEventArgs>` | BeforeQuit | アプリケーションの終了前には発生します。 | 
| `Action<Object, DocumentBeforeJumpEventArgs>` | DocumentBeforeJump | ドキュメントへのジャンプの前に発生します。 | 
| `Action<Object, DocumentBeforeParseEventArgs>` | DocumentBeforeParse | ドキュメントのアウトライン解析の前に発生します。 | 
| `Action<Object, IssueCancelEventArgs>` | IssueBeforeDelete | 指摘が削除される前に発生します | 
| `Action<Object, IssueEventArgs>` | IssueEdit | 指摘の属性が編集されたときに発生します | 
| `Action<Object, IssueLinkBeforeJumpEventArgs>` | IssueLinkBeforeJump | 指摘リンクへのジャンプの前に発生します。 | 
| `Action<Object, IssueLocationBeforeJumpEventArgs>` | IssueLocationBeforeJump | 指摘箇所へのジャンプの前に発生します。 | 
| `Action<Object, IssueEventArgs>` | IssueNew | 指摘が新規作成されたときに発生します | 
| `Action<Object, IssueEventArgs>` | IssueSelectionChanged | 指摘の選択が変更された時に発生します | 
| `Action<Object, OutlineNodeBeforeJumpEventArgs>` | OutlineNodeBeforeJump | アウトラインノードへのジャンプの前に発生します。 | 
| `Action<Object, ReviewAfterCloseEventArgs>` | ReviewAfterClose | レビューが閉じた後に発生します。 | 
| `Action<Object, ReviewEventArgs>` | ReviewAfterOpen | レビューを開いた後に発生します。 | 
| `Action<Object, ReviewEventArgs>` | ReviewAfterSave | レビューの保存後に発生します。 | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeClose | レビューが閉じる前に発生します。 | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeOpen | レビューを開く前に発生します。 | 
| `Action<Object, ReviewCancelEventArgs>` | ReviewBeforeSave | レビューの保存前に発生します。 | 
| `Action<Object, ReviewEventArgs>` | ReviewNew | レビューを新規作成すると発生します | 
| `Action<Object, ReviewOnOpenEventArgs>` | ReviewOnOpen | レビューを開く処理の開始時に発生します。 | 
| `Action<Object, ReviewOnSaveEventArgs>` | ReviewOnSave | レビューの保存開始時に発生します。 | 
| `Action<Object, EventArgs>` | Startup | アプリケーションの起動が完了したときに発生します | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | CloseAllReviewWindows() | 全てのレビューウインドウを閉じます。 | 
| `IReviewFileService` | GetReviewFileService() | レビューファイルをReviewWindowを伴わずに編集を実現するサービスを取得します | 
| `IReviewWindow` | GetReviewWindowByFileName(`String` filename) | 新しいレビューウィンドウで、指定したレビューファイルを開きます。 | 
| `IReviewWindow` | NewReviewWindow() | 新しいレビューウインドウを新規作成します。 | 
| `Boolean` | Quit(`Boolean` discard = True) | アクティブなレビューウインドウを閉じます | 
| `void` | RegisterDocumentParser() | ドキュメントパーサを登録 | 
| `void` | RemoveDocumentParser() | ドキュメントパーサを削除 | 
| `Boolean` | Restart(`Boolean` discard = True) | アプリケーションを終了して再起動します | 
| `RunScriptResult` | RunScriptFile(`String` filePath, `IDictionary<String, Object>` scriptParams = null) | スクリプトを実行します。 | 
| `void` | ShowReviewExplorer() | レビューエクスプローラを表示します。 | 
| `IDisposable` | SuspendEvent() | イベントの発生を一時的に抑制できます。  イベントのハンドラで編集APIを呼び出した結果、イベントが再帰的に発生して無限ループになってしまう事を抑制できます。  例えば、指摘の編集イベントを追加し、そのイベントで指摘を編集すると編集イベントが再度発生します。  これを抑制するために、一時的に編集イベント内でSusupendEventを呼び出すことですべてのイベント発生を抑制できます。 | 
| `void` | TrackEvent(`String` name, `IDictionary<String, String>` properties = null) | ユーザーが情報収集に同意している場合に限り、指定した引数の値でサーバーにログを登録する | 


## `IDocument`

ドキュメントの編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.IDocument
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<IOutlineNode>` | AllNodes | すべてのノードのアウトライン順コレクションを取得します。 | 
| `String` | ApplicationType | ドキュメントに関連づいているアプリケーションを取得・設定します。 | 
| `IEntityCollection<IDocumentLink>` | DocumentLinks | ドキュメントの関連リンクの一覧を取得します。 | 
| `String` | FirstDocumentLinkPath | ドキュメントの関連リンクの一つ目のパスを取得します。 | 
| `String` | Name | ドキュメント名（表示用の名前）を取得・設定します。 | 
| `IOutlineNode` | OutlineTree | アウトラインツリーのルートノードを取得します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IIssue` | AddIssue() | 指摘を追加します。 | 


## `IDocumentParser`

ドキュメントのアウトライン解析を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.IDocumentParser

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<String>` | FileExtensions | パーサーが対応している拡張子の一覧を取得します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | IsParserFor(`String` filePath) | パーサーが指定したファイルの拡張子に対応しているかを検証します。 | 
| `Boolean` | Jump(`IDocument` document, `String` physicalLocationXml, `String` filePath = ) | ドキュメントの該当位置にジャンプします。 | 
| `Boolean` | Parse(`IDocument` document, `String` filePath = ) | ドキュメントをアウトライン解析します。 | 


## `IDocumentParserMetadata`

ドキュメントパーサのメタデータ
```csharp
public interface LightningReview.ExtensionFramework.IDocumentParserMetadata

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | EnglishLabel |  | 
| `String` | Label |  | 


## `IEntityBase`

各エンティティに共通するプロパティの編集を実現するインターフェース
```csharp
public interface LightningReview.ExtensionFramework.IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | CreatedBy | 作成者 | 
| `Nullable<DateTime>` | CreatedDateTime | 作成日時 | 
| `String` | GID | グローバルID    オブジェクトを一意に識別するためのID  アプリケーション側でインスタンス生成ごとに割り当てて、永遠に変更しない。  レビューファイルのマージで、同一インスタンスを識別するために使用する。 | 
| `String` | Id | ローカルID    ユーザがオブジェクトを識別するために使用するID  インスタンス作成直後は不定値（ユーザには表示せず、内部的には定数値）とし、  ファイルへ保存した時点で、ファイル内でユニークな連番を割り当てる。    レビューごとに、そのデータ種別に対するユニーク性を保証する。  つまり、あるレビューで同じLIDをもつエンティティは、データ種別ごとに最大1つである。  データを削除した場合、そのLIDは欠番として再利用しない。  最大のLIDをもつデータを削除した場合でも、再利用はしない。  （つまり、過去に割り当てた最大値＋１を割り当てる） | 
| `String` | LastUpdatedBy | 最終更新者 | 
| `Nullable<DateTime>` | LastUpdatedDateTime | 最終更新日時 | 
| `IEnumerable<IMetaData>` | MetaDatas | メタデータのコレクション | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `T` | GetMetaData(`String` key, `T` defaultValue = null, `Boolean` decrypt = False) | 指定したキーのメタデータを取得する。 | 
| `Boolean` | RemoveMetaData(`String` key) | 指定したキーのメタデータを削除する。  キーが存在しなければfalseを返す。 | 
| `IMetaData` | SetMetaData(`String` key, `Object` value, `Boolean` encrypt = False) | 指定したキーのメタデータを設定する。  すでにキーが存在している場合いは上書きする。 | 


## `IExtensionBase`

エクステンションのI/Fクラス
```csharp
public interface LightningReview.ExtensionFramework.IExtensionBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | AppBase | アプリケーション | 
| `Boolean` | Deactivated | 非アクティブ化したか | 
| `String` | Id | エクステンションのId | 
| `String` | InstallFolder | エクステンションがインストールされているフォルダ | 
| `String` | Name | エクステンションの名前 | 
| `IExtensionSettings` | Settings | エクステンションの設定を保存・復元します  エクステンションのインストールフォルダにsettings.jsonを作成します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Activate(`IHostApp` app) | エクステンションをアクティブ化します。 | 
| `void` | Deactivate() | エクステンションを非アクティブ化します。 | 


## `IExtensionCommandBase`

エクステンション用コマンドの機能を提供するインターフェイス
```csharp
public interface LightningReview.ExtensionFramework.IExtensionCommandBase
    : IExtensionObject, ICommand

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Description | コマンドの説明 | 
| `String` | IconResourceName | アイコンのリソース名 | 
| `Key` | Key | ショートカットキー | 
| `ModifierKeys` | Modifiers | ショートカットキーを実行するための修飾キー | 
| `String` | ResourceFileFullName | アイコンのリソースファイルの完全修飾名(拡張子は除く)。  通常は使わないが、dotNet Coreへの拡張性を高めるために用意している。  (dotNet CoreとdotNet Frameworkはリソースファイルのデフォルトパスが異なる。)  例：'MyApplication.MyResource.Resources.resx' というリソース ファイルの場合は 'MyResource.Resources'となる。  未設定の場合は、'[エクステンションのアセンブリ名].Properties.Resources'となる。 | 
| `String` | Shortcut | ショートカットキーの表示文字列 | 
| `String` | Title | コマンド名(メニュー名) | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Image` | GetIconImage() | アイコンのイメージを取得する | 


## `IExtensionMetadata`

エクステンションのメタデータ
```csharp
public interface LightningReview.ExtensionFramework.IExtensionMetadata

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | EnglishLabel | エクステンションの表示名  （言語が英語の場合の表示名） | 
| `String` | Id | エクステンションのId  設定のキーになります。ユニークな値にしてください。    "MyCompany.MyExtension" のようにすると重複がないでしょう。 | 
| `String` | Label | エクステンションの表示名 | 
| `String` | MinAppVersion | エクステンションを必須のアプリケーションバージョン  "1.7.0.0"のように記述する | 


## `IExtensionObject`

```csharp
public interface LightningReview.ExtensionFramework.IExtensionObject

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | AppBase |  | 
| `IExtensionBase` | Extension |  | 


## `IExtensionSettings`

エクステンションの設定を保存できます。  アプリケーションのAppDataの下にextensionSettings.jsonを作成します。  AppData/Local/DENSO CREATE/Lightning Review/extensionSettings.json
```csharp
public interface LightningReview.ExtensionFramework.IExtensionSettings

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | ExtensionId |  | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `T` | GetValue(`String` key, `T` defaultValue = null) |  | 
| `void` | Load() |  | 
| `void` | Save() |  | 
| `void` | SetValue(`String` key, `Object` value) |  | 


## `IExtensionUIService`

確認ダイアログやエラーダイアログなどのUIを表示する機能を提供するインターフェイス
```csharp
public interface LightningReview.ExtensionFramework.IExtensionUIService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | ShowConfirmDialog(`String` message) | OK/Cancelの確認ダイアログの表示 | 
| `void` | ShowExcecption(`IExtensionBase` extension, `Exception` e, `String` message = ) | 例外のエラーの表示  UserExceptionの場合はユーザー向け表示、そうでない場合はシステムエラーとして表示する。  従って、ファイル系の例外などはユーザ例外としてキャッチしなおすことが必要。 | 
| `void` | ShowExcecption(`Exception` e, `String` message = ) | 例外のエラーの表示  UserExceptionの場合はユーザー向け表示、そうでない場合はシステムエラーとして表示する。  従って、ファイル系の例外などはユーザ例外としてキャッチしなおすことが必要。 | 
| `void` | ShowMessageBox(`String` message) | メッセージボックスの表示 | 


## `IHostApp`

```csharp
public interface LightningReview.ExtensionFramework.IHostApp

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IList<String>` | ExtensionFolders | エクステンションをロードするフォルダ | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `MenuBuilder` | RegisterMenu(`IExtensionBase` Extension) | メニューのビルダーを戻します。 | 
| `ToolBarItemBuilder` | RegisterToolBarItem(`IExtensionBase` Extension) | ツールバーに追加するアイテムのビルダーを戻します。 | 
| `void` | RemoveMenu(`String` location, `String` menuName, `String` parentMenuName = ) | ロケーションと親メニュー名を指定して、指定した名前のメニューを削除します。  親メニュー名の指定がない場合は、ロケーションに対応するメニューから指定した名前のメニューを削除します。 | 


## `IIssue`

指摘の編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.IIssue
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AssignedTo | 修正者 | 
| `Boolean` | CanSendBack | 差し戻すことができるか  ステータスの変更に合わせてOnPropertyChangedを発行する | 
| `String` | Category | 分類 | 
| `String` | Comment | コメント | 
| `String` | ConfirmedBy | 確認者 | 
| `String` | CorrectionPolicy | 修正方針 | 
| `IEnumerable<ICustomField<ICustomFieldDefinition>>` | CustomFields | カスタムフィールドの値を取得します。 | 
| `Nullable<DateTime>` | DateConfirmed | 確認日 | 
| `Nullable<DateTime>` | DateFixed | 修正日 | 
| `Nullable<DateTime>` | DateReported | 報告日 | 
| `String` | Description | 説明 | 
| `String` | DetectionActivity | 検出工程 | 
| `String` | DocumentID | 対象ドキュメント | 
| `Nullable<DateTime>` | DueDate | 期日 | 
| `Int32` | FixedImageCount | 修正画像数 | 
| `Boolean` | HasBeenSentBack | 過去に一度でも差し戻しがあったことを記録するフラグ | 
| `String` | Importance | 重大度  本プロパティの値域と、それぞれの値に対応する重大度を以下に示します。    [値域]  [値に対応する重大度]  Low  低  Middle  中  High  高 | 
| `String` | InjectionActivity | 原因工程 | 
| `Boolean` | IsFiltered | 指摘にフィルタがかかっているか | 
| `Boolean` | IsSendingBack | 現在差戻し中かどうかをあらわすフラグ | 
| `String` | NeedToFix | 対策要否  本プロパティの値域と、それぞれの値に対応する対策要否を以下に示します。    [値域]  [値に対応する対策要否]  Yes  はい  No  いいえ  Suspended  保留 | 
| `IEntityCollection<IIssueLink>` | NotRevisedLinks | 指摘の修正前リンクの一覧を取得します。 | 
| `String` | OutlineName | 場所（関連付けられているアウトラインノードの名前） | 
| `IOutlineNode` | OutlineNode | 関連付けられているアウトラインノード | 
| `String` | OutlinePath | 場所 | 
| `String` | Priority | 優先度  本プロパティの値域と、それぞれの値に対応する優先度を以下に示します。    [値域]  [値に対応する優先度]  Low  低  Middle  中  High  高 | 
| `String` | Reason | 指摘理由 | 
| `String` | ReportedBy | 報告者 | 
| `Int32` | ReportedImageCount | 指摘画像数 | 
| `String` | Resolution | 対策 | 
| `IReviewSetting` | Review | この指摘が登録されているレビュー  外部からは変更できません。 | 
| `IEntityCollection<IIssueLink>` | RevisedLinks | 指摘の修正後リンクの一覧を取得します。 | 
| `String` | RootOutlinePath | 場所（ルートレベルのアウトラインノードの名前） | 
| `String` | SendingBackReason | 差し戻し理由 | 
| `String` | Status | 指摘のステータスを取得または設定(差し戻し考慮なし)します。  本プロパティの値域と、それぞれの値に対応するステータスを以下に示します。    [値域]  [値に対応するステータス]  NotRevised  未修正  CorrectionPolicyExamined  修正方針検討済み  CorrectionPolicyApproved  修正方針承認済み  Revised  修正済み  Confirmed  確認済み | 
| `String` | Type | タイプ  本プロパティの値域と、それぞれの値に対応するタイプを以下に示します。    [値域]  [値に対応するタイプ]  Bug  不具合  Suggestion  指摘  GoodPoint  グッドポイント | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | AddFixedImage(`String` filePath, `Int32` imageNumber) | 修正画像を追加する | 
| `void` | AddReportedImage(`String` filePath) | 指摘画像を追加する | 
| `void` | ClearAllFixedImages() | 全ての修正画像を削除する | 
| `void` | ClearAllReportedImages() | 全ての指摘画像を削除する | 
| `void` | DeleteFixedImage(`Int32` index) | 修正画像を削除する | 
| `void` | DeleteReportedImage(`Int32` index) | 指摘画像を削除する | 
| `IEnumerable<IIssueImage>` | GetFixedImages() | 修正画像の一覧を取得する | 
| `IEnumerable<IIssueImage>` | GetReportedImages() | 指摘画像の一覧を取得する | 


## `IOutlineNode`

アウトラインの編集を実現するインタフェース
```csharp
public interface LightningReview.ExtensionFramework.IOutlineNode
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<IOutlineNode>` | ChildNodes | 子ノードのアウトライン順コレクション | 
| `IDocument` | Document | このノードが属するドキュメント | 
| `IEnumerable<IIssue>` | Issues | このノードに関連付いている指摘のコレクション | 
| `Int32` | Level | アウトラインレベル  トップレベルを１とした深さを表します。 | 
| `String` | Name | ノード名 | 
| `IOutlineNode` | Parent | 親ノード  nullの場合はルートレベルのノードです。 | 
| `String` | Path | ノードパス  トップレベルからのノード名をデリミタ "/" で結合した文字列です。  文字列の先頭にもデリミタが付きます。  デリミタで区切られた最初のノード名は必ずドキュメント名になります。  <example>  以下の親子階層になっている場合、ノードパスは "/AAA/BBB/CCC" となります。  AAA -&gt; BBB -&gt; CCC  </example> | 
| `String` | PhysicalLocationXml | ドキュメントにおける物理位置をXML形式で表現したもの | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IOutlineNode` | AddChild(`String` nodeName) | 子にアウトラインを追加する | 
| `IOutlineNode` | AddChild(`String` nodeName, `String` physicalLocationXml) | 子にアウトラインを追加する | 
| `IIssue` | AddIssue() | 指摘を追加する | 
| `void` | ClearChildren() | 子ノードをすべてクリア | 
| `void` | DeleteChild(`IOutlineNode` child) | 子ノードを削除 | 


## `IReviewExplorer`

レビューエクスプローラの編集を実現するインターフェース
```csharp
public interface LightningReview.ExtensionFramework.IReviewExplorer

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | CurrentFolder | 現在選択しているフォルダのパス  未選択の場合は空文字を戻します | 
| `Boolean` | IsActive | ウィンドウがアクティブか | 
| `Boolean` | IsVisible | ウィンドウを表示しているか | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<String>` | GetReviewFiles() | 現在のフォルダのレビューファイルのパス一覧を取得します | 
| `IEnumerable<IReviewSummary>` | GetReviewSummaries() | 現在のフォルダのレビューのサマリ一覧を取得します | 
| `IEnumerable<String>` | GetSelectedReviewFilePaths() | 現在選択しているレビューファイルのパスを取得します | 
| `IEnumerable<IReviewSummary>` | GetSelectedReviewSummaries() | 現在選択しているレビューファイルのサマリを取得します | 
| `void` | Reload() | 画面を再ロードします | 


## `IReviewMember`

レビューメンバの編集を実現するインタフェース。
```csharp
public interface LightningReview.ExtensionFramework.IReviewMember
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<ICustomField<IMemberCustomFieldDefinition>>` | CustomFields | カスタムフィールドの値を取得します。 | 
| `IEnumerable<ICustomRole>` | CustomRoles | カスタムロールの値を取得します。 | 
| `Boolean` | Moderator | メンバーは確認者か | 
| `String` | Name | メンバーの名前 | 
| `Boolean` | Reviewee | メンバーはレビューイか | 
| `Boolean` | Reviewer | メンバーはレビューワか | 
| `String` | Tag | UI非表示な情報をタグとして取得または設定します。 | 


## `IReviewSetting`

レビュー設定の編集を実現するインタフェース
```csharp
public interface LightningReview.ExtensionFramework.IReviewSetting
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Nullable<DateTime>` | ActualDate | 実績実施日 | 
| `Nullable<Double>` | ActualScale | 実績規模 | 
| `Nullable<Double>` | ActualTime | 実績時間(分単位) | 
| `String` | CategoryAllowedValues | 分類の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  分類の選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | CategoryDefaultValue | 分類のデフォルト値 | 
| `IEnumerable<ICustomFieldDefinition>` | CustomFields | 指摘のカスタムフィールドの定義を取得します。 | 
| `String` | DetectionActivityAllowedValues | 検出工程の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  検出工程の選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | DetectionActivityDefaultValue | 検出工程のデフォルト値 | 
| `String` | Domain | ドメイン | 
| `String` | DomainAllowedValues | ドメインの選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  ドメインの選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | EndCondition | 終了条件 | 
| `String` | Goal | 目的 | 
| `String` | InjectionActivityAllowedValues | 原因工程の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  原因工程の選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | InjectionActivityDefaultValue | 原因工程のデフォルト値 | 
| `Nullable<Double>` | IssueCountOfActual | 実績件数 | 
| `Nullable<Double>` | IssueCountOfGoal | 目標件数 | 
| `IEnumerable<IMemberCustomFieldDefinition>` | MemberCustomFieldDefinitions | メンバのカスタムフィールドの定義を取得します。 | 
| `IEnumerable<IMemberCustomRoleDefinition>` | MemberCustomRoleDefinitions | メンバのカスタムロールの定義を取得します。 | 
| `IEnumerable<IReviewMember>` | Members | メンバ情報のコレクション | 
| `String` | Name | レビュー名 | 
| `String` | Place | 場所 | 
| `Nullable<DateTime>` | PlannedDate | 計画実施日 | 
| `Nullable<Double>` | PlannedScale | 予定規模 | 
| `Nullable<Double>` | PlannedTime | 計画時間（分単位） | 
| `String` | ProjectCode | プロジェクトコード | 
| `String` | ProjectName | プロジェクト名 | 
| `IEnumerable<IReviewCustomFieldDefinition>` | ReviewCustomFieldDefinitions | レビューのカスタムフィールドの定義を取得します。 | 
| `IEnumerable<ICustomField<IReviewCustomFieldDefinition>>` | ReviewCustomFields | レビューのカスタムフィールドの値を取得します。 | 
| `String` | ReviewStyle | レビュー形式 | 
| `String` | ReviewStyleAllowedValues | レビュー形式の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  レビュー形式の選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | ReviewType | レビュー種別 | 
| `String` | ReviewTypeAllowedValues | レビュー種別の選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  レビュー種別の選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | Status | ステータス | 
| `IStatusItem` | StatusItem | ステータスアイテムを取得または設定します。 | 
| `IEnumerable<IStatusItem>` | StatusItems | ステータスのコレクションを取得します。 | 
| `String` | Unit | 成果物単位 | 
| `Boolean` | UseCorrectionPolicy | 修正方針を記録するか | 
| `Boolean` | UseCorrectionPolicyStatus | 修正方針ステータスを使用するか | 
| `Boolean` | UseReason | 指摘理由を記録するか | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IReviewMember` | AddMember(`String` memberName) | メンバの追加 | 
| `IStatusItem` | AddStatusItem(`String` statusName) | ステータスを追加します。 | 
| `void` | DeleteMember(`IReviewMember` member) | メンバの削除 | 
| `void` | DeleteStatusItem(`IStatusItem` status) | ステータスを削除します。 | 


## `IReviewSummary`

レビューのサマリ情報を取得するためのインターフェース
```csharp
public interface LightningReview.ExtensionFramework.IReviewSummary

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Nullable<DateTime>` | ActualDate | 実績実施日 | 
| `Int32` | AllIssueCount | 指摘の総件数 | 
| `Int32` | BugIssueCount | 種別が「不具合」の指摘件数 | 
| `Int32` | ConfirmedIssueCount | 確認済みの件数 | 
| `String` | FileName | レビューファイルの名前 | 
| `String` | FilePath | レビューファイルのパス | 
| `Int32` | GoodPointIssueCount | グッドポイントの件数 | 
| `Int32` | NotNeedToFixIssueCount | 対策不要の件数 | 
| `Int32` | NotRevisedIssueCount | 未修正の件数 | 
| `Nullable<DateTime>` | PlannedDate | 計画実施日 | 
| `Int32` | RevisedIssueCount | 修正済みの件数 | 
| `String` | Status | ステータス | 
| `Int32` | SuggestionIssueCount | 種別が「指摘」の指摘件数 | 


## `IReviewWindow`

レビューウィンドウの操作を実現するインタフェース
```csharp
public interface LightningReview.ExtensionFramework.IReviewWindow

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | IsStartPageVisible | スタートページは表示中であるかを取得します。 | 
| `IReview` | Review | レビューの操作を実現するインターフェースを取得します。 | 
| `String` | Title | レビューウィンドウのタイトルを取得または設定します。  取得または設定できるのは、" - Lightning Review"より前の部分のタイトルです。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Activate() | ウィンドウをアクティブにします。 | 
| `void` | ApplyIdFilter(`String` issueIds) | 指摘Idでフィルタします。 | 
| `IUndoTransaction` | BeginEdit(`Boolean` autoCommit = True) | 編集の開始を指定します。  （特に指定しなくても編集は可能であるがアンドゥの単位を指定できます）  必ずusingで囲ってください。 | 
| `void` | ClearDirty() | 編集履歴をクリアし、レビューを未編集の状態にします。 | 
| `Boolean` | Close(`Boolean` discard = False) | ウィンドウを閉じます。 | 
| `void` | CompleteEditing() | テキストボックスでの編集または画像の編集時に、その編集状態を確定します | 
| `IEnumerable<IDocument>` | GetSelectedDocuments() | レビューウィンドウで選択されているドキュメントの一覧を戻します。 | 
| `IEnumerable<IIssue>` | GetSelectedIssues() | 選択した指摘を取得します。 | 
| `IEnumerable<IOutlineNode>` | GetSelectedNodes() | レビューウィンドウで選択されているアウトラインツリーのアウトラインの一覧を戻します。  ドキュメントが選択されている場合、ドキュメントのルートノードを返します。 | 
| `Window` | GetWindow() | レビューウィンドウをWindow型で取得します。 | 
| `void` | NewReview(`Boolean` discard = False) | ファイルを新規作成します。  現在開いているファイルは閉じます。 | 
| `void` | NewReviewFromTemplate(`String` templateFilePath, `Boolean` discard = False) | 指定したテンプレートからレビューを新規作成します。  現在開いているファイルは閉じます。 | 
| `void` | Open(`String` filename) | ファイルを指定して開きます。  現在開いているファイルは閉じます。 | 
| `void` | ParseDocument(`IDocument` document) | 指定したドキュメントの先頭のリンクでアウトライン解析します。 | 
| `void` | ResetTitle() | レビューウィンドウのタイトルの設定を、本体側の設定に戻します。 | 
| `void` | Save() | ファイルを上書き保存します。 | 
| `void` | SaveAs(`String` filename) | ファイルを名前を付けて保存します。 | 
| `void` | SelectIssues(`IEnumerable<IIssue>` issues) | 指摘を選択します。 | 
| `void` | SelectOutlineNodes(`IEnumerable<IOutlineNode>` outlineNodes) | アウトラインツリーのアウトラインを選択します。  ドキュメントを選択する場合、ドキュメントのルートノードを引数として渡してください。 | 
| `void` | ShowIssueDetailById(`String` issueId, `Boolean` globalId = False) | 指摘のIdを指定して詳細ウィンドウを表示します。 | 
| `void` | ShowQuickReviewWindow(`String` outlinePath, `String` description = , `IDictionary<String, String>` metaDatas = null) | クイックレビューウインドウを表示します。 | 


## `IssueCancelEventArgs`

```csharp
public class LightningReview.ExtensionFramework.IssueCancelEventArgs
    : CancelEventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<IIssue>` | Issues |  | 
| `IReviewWindow` | ReviewWindow |  | 


## `IssueEventArgs`

```csharp
public class LightningReview.ExtensionFramework.IssueEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<IIssue>` | Issues |  | 
| `IReviewWindow` | ReviewWindow |  | 


## `IssueLinkBeforeJumpEventArgs`

指摘リンクへのジャンプ前イベントのイベントパラメーター
```csharp
public class LightningReview.ExtensionFramework.IssueLinkBeforeJumpEventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `IIssue` | Issue | 指摘リンクが紐づいている指摘を取得します。 | 
| `String` | IssueLinkName | ジャンプ対象の指摘リンクの名前を取得します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得します。 | 
| `String` | TargetJumpPath | ジャンプ対象となるパスを取得または設定します。 | 


## `IssueLocationBeforeJumpEventArgs`

指摘箇所へのジャンプの前イベントのイベントパラメータです。
```csharp
public class LightningReview.ExtensionFramework.IssueLocationBeforeJumpEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DocumentLinkName | ジャンプ対象のドキュメントリンクの名前を取得します。 | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `IIssue` | Issue | ジャンプ対象の指摘を取得します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得します。 | 
| `String` | TargetJumpPath | ジャンプ対象となるパスを取得または設定します。 | 


## `Menu`

メニュー情報
```csharp
public class LightningReview.ExtensionFramework.Menu

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | App | アプリケーション | 
| `IExtensionCommandBase` | Command | 実行するコマンド | 
| `String` | Id | ID | 
| `MenuInsertPos` | InsertPos | メニューの挿入位置 | 
| `Boolean` | IsCheckable | チェックが可能か | 
| `Boolean` | IsChecked | チェック状態 | 
| `IList<Menu>` | Items | 子要素として持つアイテム | 
| `Key` | Key | ショートカットキー | 
| `String` | Location | ロケーション | 
| `MenuType` | MenuType | 種類 | 
| `ModifierKeys` | Modifiers | ショートカットキーを実行するための修飾キー | 
| `String` | ParentMenu | 親のメニュー名 | 
| `MenuSeparatorInsertPos` | SeparatorInsertPos | セパレータの挿入位置 | 
| `String` | Shortcut | ショートカットキーの表示文字列 | 
| `String` | SiblingMenu | 兄弟のメニュー名 | 
| `String` | Title | タイトル | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | AddMenuItem(`Menu` menu) | メニューを追加する | 
| `void` | ExecuteCommand() | コマンドを実行する | 
| `Image` | GetIconImage() | アイコンのイメージを取得する | 


## `MenuBuilder`

メニューのビルダークラス
```csharp
public class LightningReview.ExtensionFramework.MenuBuilder

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `MenuBuilder` | After(`String` siblingMenu) | メニューを挿入する場所を兄弟として指定したメニューの後に設定する | 
| `MenuBuilder` | Before(`String` siblingMenu) | メニューを挿入する場所を兄弟として指定したメニューの前に設定する | 
| `MenuBuilder` | Bottom() | メニューを挿入する場所を末尾に設定する。 | 
| `void` | Build() | 本クラスで作成したメニューをUIとして構築するための準備を完了させる。 | 
| `MenuBuilder` | Command() | 実行するコマンドを設定する。 | 
| `MenuBuilder` | Location(`String` location) | メニューを設定する場所    "ReviewWindow/MainMenu"  "ReviewWindow/Issues/ContextMenu" | 
| `MenuBuilder` | Parent(`String` parentMenu) | このメニューを親としてメニューを作成します。  メニューの表示名を指定して下さい。  '|'で区切ると複数の選択肢を設定できます。日本語・英語に対応して検索できます。  'ツール|tool'の場合は、「ツール」か「Tool」（大文字小文字区別しません）を含むメニューの子供に挿入します。 | 
| `MenuBuilder` | SetCheckableMenu(`Boolean` isChecked = False) | チェック状態の切り替えが可能なメニューとして振舞うように設定する(未実装なので利用しないでください)  ExtensionCommandクラスのOnExecuteメソッドの引数でメニューをクリックした後のメニューのチェック状態(Menu.IsChecked)を渡します。  OnExecuteメソッドの引数をbool型にキャストして、メニューのチェック状態を取得してください。  OnExecuteメソッドの引数がtrueであれば、メニューを押したことによってメニューがチェック状態になったことを意味します。  OnExecuteメソッドの引数がfalseであれば、メニューを押したことによってメニューがチェック状態でなくなったことを意味します。 | 
| `MenuBuilder` | SetMenu() | メニューとして振舞うように設定する(未実装なので利用しないでください) | 
| `MenuBuilder` | Top() | メニューを挿入する場所を先頭に設定する | 
| `MenuBuilder` | WithSeparatorAfter() | セパレーターをメニューの直後に挿入する | 
| `MenuBuilder` | WithSeparatorBefore() | セパレーターをメニューの直前に挿入する | 


## `MenuInsertPos`

メニューの挿入位置
```csharp
public enum LightningReview.ExtensionFramework.MenuInsertPos
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | Before | 兄弟として指定したメニューの前 | 
| `1` | After | 兄弟として指定したメニューの後 | 
| `2` | Top | 先頭 | 
| `3` | Bottom | 末尾 | 


## `MenuSeparatorInsertPos`

メニューセパレータの挿入位置
```csharp
public enum LightningReview.ExtensionFramework.MenuSeparatorInsertPos
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | None | セパレータなし | 
| `1` | Before | メニュー上部 | 
| `2` | After | メニュー下部 | 


## `OutlineNodeBeforeJumpEventArgs`

アウトラインへのジャンプの前イベントのイベントパラメータです。
```csharp
public class LightningReview.ExtensionFramework.OutlineNodeBeforeJumpEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DocumentLinkName | ジャンプ対象のドキュメントリンクの名前を取得します。 | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `IOutlineNode` | OutlineNode | ジャンプ対象のアウトラインノードを取得します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得します。 | 
| `String` | TargetJumpPath | ジャンプ対象となるパスを取得または設定します。 | 


## `ReviewAfterCloseEventArgs`

```csharp
public class LightningReview.ExtensionFramework.ReviewAfterCloseEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | FilePath |  | 


## `ReviewCancelEventArgs`

```csharp
public class LightningReview.ExtensionFramework.ReviewCancelEventArgs
    : CancelEventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IReviewWindow` | ReviewWindow |  | 


## `ReviewEventArgs`

```csharp
public class LightningReview.ExtensionFramework.ReviewEventArgs
    : EventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IReviewWindow` | ReviewWindow |  | 


## `ReviewOnOpenEventArgs`

レビューの開く処理の開始時イベントのイベントパラメータ
```csharp
public class LightningReview.ExtensionFramework.ReviewOnOpenEventArgs
    : CancelEventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得または設定します。 | 
| `String` | SavingFilePath | 開く対象のファイルパスを取得または設定します。 | 


## `ReviewOnSaveEventArgs`

レビューの保存開始時イベントのイベントパラメータ
```csharp
public class LightningReview.ExtensionFramework.ReviewOnSaveEventArgs
    : CancelEventArgs

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | Handled | イベントが処理されたかどうかを取得または設定します。 | 
| `Boolean` | IsOverwrite | 上書き保存かどうかを取得します。  上書き保存はtrue、名前を付けて保存はfalseです。 | 
| `IReviewWindow` | ReviewWindow | レビューウィンドウを取得または設定します。 | 


## `ThemeHelper`

UIのテーマを設定する
```csharp
public static class LightningReview.ExtensionFramework.ThemeHelper

```

Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IApp` | App | エクステンションのホストアプリ | 


Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | SetCustomTheme(`SolidColorBrush` background, `SolidColorBrush` foreground) | 任意のテーマに設定する | 
| `void` | SetThemeColor(this `Window` window) | ウィンドウにテーマの色を設定する | 
| `SolidColorBrush` | ToSolidColorBrush(`String` htmlColor) | Colorの文字列形式(#FFFFFFなど)をもとにSolidColorBrushを返す | 


## `UserException`

ユーザーに対してエラーの解決方法を知らせるための例外
```csharp
public class LightningReview.ExtensionFramework.UserException
    : Exception, ISerializable, _Exception

```

## `ViewModelBase`

ビューモデルの基底クラス
```csharp
public class LightningReview.ExtensionFramework.ViewModelBase
    : BindableBase, INotifyPropertyChanged

```

