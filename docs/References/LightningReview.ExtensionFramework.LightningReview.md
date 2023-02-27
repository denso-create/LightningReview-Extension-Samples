## `ICustomField<TDefinition>`

カスタムフィールドの編集を実現するインターフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.ICustomField<TDefinition>

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `TDefinition` | Definition | カスタムフィールドの定義を取得します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | GetValue() | カスタムフィールドの値を取得します。 | 
| `void` | SetValue(`String` value) | カスタムフィールドの値を設定します。 | 


## `ICustomFieldDefinition`

指摘のカスタムフィールド定義の編集を実現するインタフェース
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.ICustomFieldDefinition
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AllowedValues | 選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定する。  選択肢のリストを改行区切りで連結した文字列を取得する。  取得・設定ともリストの並び順と一致することを保証する。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持する。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視する（削除する）。 | 
| `String` | DefaultValue | デフォルト値 | 
| `String` | DisplayName | 表示名  他のフィールドと重複していても構わないが、空文字列にはできない。  空文字列を指定した場合は、元の値に戻す。 | 
| `Boolean` | Enabled | フィールドを使用するか否か | 


## `ICustomRole`

カスタムロールの編集を実現するインターフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.ICustomRole

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IMemberCustomRoleDefinition` | Definition | カスタムロールの定義を取得します。 | 
| `Boolean` | IsAssigned | カスタムロールに割り当てられているかを取得または設定します。 | 


## `IDocumentLink`

ドキュメントの関連リンクの編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IDocumentLink
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Name | ドキュメントの関連リンクの名前です。 | 
| `String` | Path | ドキュメントの関連リンクのパスです。 | 
| `String` | Tag | ドキュメントの関連リンクのタグです。 | 


## `IEntityCollection<T>`

エンティティのコレクションの操作を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IEntityCollection<T>
    : IEnumerable<T>, IEnumerable

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `T` | Add() | エンティティをコレクションに追加します。 | 
| `void` | Remove(`T` entity) | エンティティをコレクションから削除します。 | 
| `void` | RemoveAt(`Int32` index) | インデックスを指定してエンティティをコレクションから削除します。 | 


## `IIssueImage`

指摘画像の編集を実現するインタフェース
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IIssueImage
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `BitmapImage` | Image | 画像のイメージ | 
| `String` | ImageTemporaryFilePath | イメージ保存先のテンポラリフォルダのパス | 
| `String` | Name | 画像名(ID=1-1の修正画像の場合は'1-1'となる) | 
| `Int32` | ReportedImageNo | 関連する指摘画像の番号(ID=1-1の修正画像の場合は'1'となる) | 


## `IIssueLink`

指摘の関連リンクの編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IIssueLink
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Name | 指摘の関連リンクの名前です。 | 
| `String` | Path | 指摘の関連リンクのパスです。 | 
| `String` | Tag | 指摘の関連リンクのタグです。 | 


## `IMemberCustomFieldDefinition`

メンバのカスタムフィールド定義の編集を実現するインタフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IMemberCustomFieldDefinition
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DisplayName | 表示名を取得または設定します。  他のフィールドと重複していても構いませんが、空文字列にはできません。  空文字列を指定した場合は、元の値に戻します。 | 
| `Boolean` | Enabled | フィールドを使用するか否かを取得または設定します。 | 


## `IMemberCustomRoleDefinition`

メンバのカスタムロール定義の編集を実現するインタフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IMemberCustomRoleDefinition
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | DisplayName | 表示名を取得または設定します。  他のフィールドと重複していても構いませんが、空文字列にはできません。  空文字列を指定した場合は、元の値に戻します。 | 
| `Boolean` | Enabled | フィールドを使用するか否かを取得または設定します。 | 


## `INote`

ノートの編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.INote
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Content | ノートの内容を取得・設定します。 | 
| `String` | ContentType | ノートの内容の種類を取得・設定します。 | 
| `String` | GroupName | ノートが所属するノートグループ名を取得・設定します。 | 
| `String` | Name | ノート名を取得・設定します。 | 


## `INoteGroup`

ノートグループの編集を実現するインタフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.INoteGroup
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Name | ノートグループ名を取得・設定します。 | 


## `IReview`

レビューの操作を実現するインターフェースです。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IReview
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IEnumerable<IDocument>` | Documents | レビューファイルに関連づくドキュメントの一覧を取得します。 | 
| `String` | FilePath | レビューファイルの絶対パスを取得します。 | 
| `Boolean` | IsDirty | 前回の保存時からレビューが変更されたかどうかを取得します。 | 
| `IEnumerable<INoteGroup>` | NoteGroups | レビューファイルに関連づくノートグループの一覧を取得します。 | 
| `IEnumerable<INote>` | Notes | レビューファイルに関連づくノートの一覧を取得します。 | 
| `IReviewSetting` | ReviewSetting | レビューの設定オブジェクトを取得します。 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IDocument` | AddDocument() | このコンテキストが保持しているレビューデータにドキュメントを追加します。 | 
| `IDocument` | AddDocument(`String` filePath) | このコンテキストが保持しているレビューデータにドキュメントを追加します。 | 
| `IIssue` | AddIssue(`IDocument` document) | 対象のドキュメントに指摘を追加します。 | 
| `IIssue` | AddIssue(`IDocument` document, `String` outlinePath) | 対象のドキュメントに指摘を追加します。 | 
| `IIssue` | AddIssue(`IOutlineNode` node) | 対象のドキュメントに指摘を追加します。 | 
| `INote` | AddNote(`String` name, `String` contentType = Markdown, `String` groupName = null) | ノートを追加します。  ノートの内容の種類と所属するノートグループ名を指定して追加できます。 | 
| `INoteGroup` | AddNoteGroup(`String` name) | ノートグループを追加します。 | 
| `void` | DeleteDocument(`IDocument` document) | 既存のドキュメントを削除します。 | 
| `void` | DeleteIssue(`IIssue` issue) | 指摘を削除します。 | 
| `void` | DeleteIssueById(`String` issueId, `Boolean` globalId = False) | 指摘のIdを指定して指摘を削除します。 | 
| `void` | DeleteNote(`INote` note) | ノートを削除します。 | 
| `void` | DeleteNoteGroup(`INoteGroup` noteGroup) | ノートグループを削除します。 | 
| `IEnumerable<IIssue>` | GetAllIssues() | レビューファイルに関連づく指摘の一覧を取得します。 | 
| `IDocument` | GetDocument(`String` filePath) | 指定したファイル名のドキュメントを取得します。  ファイル名の大・小文字は区別しません。 | 
| `IIssue` | GetIssue(`String` issueId, `Boolean` globalId = False) | 指摘のIdを指定して指摘を取得します。 | 


## `IReviewCustomFieldDefinition`

レビューのカスタムフィールド定義の編集を実現するインターフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IReviewCustomFieldDefinition
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | AllowedValues | 選択肢のリストをカンマ区切りもしくは改行区切りで連結した文字列を設定します。  選択肢のリストを改行区切りで連結した文字列を取得します。  取得・設定ともリストの並び順と一致することを保証します。  設定時は、既存項目と一致するものについては「説明」などの他情報を保持します。  設定時は、カンマの前後に含まれる空白文字（スペース、タブ）と  文字列中に含まれるすべての改行文字を無視します（削除する）。 | 
| `String` | DisplayName | 表示名を取得または設定します。  他のフィールドと重複していても構わないが、空文字列にはできません。  空文字列を指定した場合は、元の値に戻します。 | 
| `Boolean` | Enabled | フィールドを使用するか否かを取得または設定します。 | 
| `String` | Group | 所属するグループを取得または設定します。 | 


## `IReviewFileService`

レビューファイルをReviewWindowを伴わずに編集を実現するサービスのインターフェース
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IReviewFileService

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | CloseReview(`IReview` review) | レビューを閉じます | 
| `IReview` | NewReview() | レビューを新規作成します | 
| `IReview` | OpenReview(`String` filepath, `Boolean` readOnly = False) | レビューを開きます。  開くことに失敗した場合はUserExceptionをthrowします。 | 
| `void` | SaveReview(`String` filepath, `IReview` review) | レビューを保存します | 


## `IStatusItem`

ステータスの編集を実現するインターフェース。
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IStatusItem
    : IEntityBase

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Color | ステータスの色を取得または設定します。デフォルトでは[None]が設定されています。 | 
| `Boolean` | IsClosed | クローズを意味するステータスかを取得または設定します。 | 
| `Boolean` | IsSelected | このステータスが、現在のステータスとして設定されているかを取得・設定します。  この値をtrueに変更した場合、他のすべてのステータスの値はfalseになります。 | 
| `String` | Name | ステータスの名前を取得または設定します。  他の選択肢と重複していても構いませんが、空文字列にはできません。  空文字列を指定した場合は、元の値に戻します。 | 
| `String` | SelectedBy | 設定者名を取得または設定します。  ステータスを設定したユーザー名が自動入力されます。 | 
| `Nullable<DateTime>` | SelectedOn | 設定日を取得または設定します。  ステータスを設定した日付が自動入力されます。 | 


## `IUndoTransaction`

アンドゥのトランザクションを実現するインターフェース
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.IUndoTransaction
    : IDisposable

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Commit() | トランザクションを開始してからの編集をコミットします | 
| `void` | Rollback() | トランザクションを開始してからの編集をロールバックします | 


