## `MenuType`

メニューの種類
```csharp
public enum LightningReview.ExtensionFramework.Framework.MenuType
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | Menu | 通常のメニュー | 
| `1` | CheckableMenu | チェック状態の切り替えが可能なメニュー | 


## `RemoveMenuInfo`

削除するメニューの情報
```csharp
public class LightningReview.ExtensionFramework.Framework.RemoveMenuInfo

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Location | ロケーション | 
| `String` | MenuName | 削除するメニュー名 | 
| `String` | ParentMenuName | 親メニュー名 | 


## `ToolBar`

ツールバー情報
```csharp
public class LightningReview.ExtensionFramework.Framework.ToolBar

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | Id | ID | 
| `IList<ToolBarItem>` | Items | 子要素として持つアイテム | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | AddToolBarItem(`ToolBarItem` toolBarItem) | ツールバーにアイテムを追加 | 


## `ToolBarItem`

ツールバーに追加するアイテム
```csharp
public class LightningReview.ExtensionFramework.Framework.ToolBarItem

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | App | アプリケーション | 
| `IExtensionCommandBase` | Command | 実行するコマンド | 
| `String` | Id | ID | 
| `ToolBarItemInsertPos` | InsertPos | アイテムの挿入位置 | 
| `Boolean` | IsChecked | チェック状態 | 
| `String` | Location | ロケーション | 
| `ToolBarItemSeparatorInsertPos` | SeparatorInsertPos | セパレータの挿入位置 | 
| `String` | SiblingItem | 兄弟アイテム名 | 
| `String` | Title | タイトル | 
| `ToolBarItemDisplayStyle` | ToolBarItemDisplayStyle | 表示スタイル | 
| `ToolBarItemType` | ToolBarItemType | 種類 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | ExecuteCommand() | コマンドを実行する | 
| `Image` | GetIconImage() | アイコンのイメージを取得する | 


## `ToolBarItemBuilder`

ツールバーに追加するアイテムのビルダークラス
```csharp
public class LightningReview.ExtensionFramework.Framework.ToolBarItemBuilder

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `ToolBarItemBuilder` | After(`String` siblingItem) | アイテムの追加先を兄弟として指定したアイテムの後に設定する | 
| `ToolBarItemBuilder` | Before(`String` siblingItem) | アイテムの追加先を兄弟として指定したアイテムの前に設定する | 
| `ToolBarItemBuilder` | Bottom() | アイテムの追加先を末尾に設定する | 
| `void` | Build() | 本クラスで作成したアイテムをUIとして構築するための準備を完了させる。 | 
| `ToolBarItemBuilder` | Command() | 実行するコマンドを設定 | 
| `ToolBarItemBuilder` | Location(`String` location) | アイテムを追加するツールバーの場所を設定する    "ReviewWindow/ToolBar" | 
| `ToolBarItemBuilder` | SetButton() | ボタンとして振舞うように設定する | 
| `ToolBarItemBuilder` | SetImageAndTextStyle() | テキストとイメージで表現するアイテムとなるように設定する | 
| `ToolBarItemBuilder` | SetImageStyle() | イメージで表現するアイテムとなるように設定する | 
| `ToolBarItemBuilder` | SetTextStyle() | テキストで表現するアイテムとなるように設定する | 
| `ToolBarItemBuilder` | SetToggleButton(`Boolean` isChecked = False) | トグルボタンとして振る舞うように設定する  ExtensionCommandクラスのOnExecuteメソッドの引数でボタンをクリックした後のトグルボタンのチェック状態(ToggleButton.IsChecked)を渡します。  OnExecuteメソッドの引数をbool型にキャストして、トグルボタンのチェック状態を取得してください。  OnExecuteメソッドの引数がtrueであれば、トグルボタンを押したことによってトグルボタンがチェック状態になったことを意味します。  OnExecuteメソッドの引数がfalseであれば、トグルボタンを押したことによってトグルボタンがチェック状態でなくなったことを意味します。 | 
| `ToolBarItemBuilder` | Top() | アイテムの追加先を先頭に設定する | 
| `ToolBarItemBuilder` | WithSeparatorAfter() | セパレーターをアイテムの直後に挿入する | 
| `ToolBarItemBuilder` | WithSeparatorBefore() | セパレーターをアイテムの直前に挿入する | 


## `ToolBarItemDisplayStyle`

ツールバーに追加するアイテムの表示スタイル
```csharp
public enum LightningReview.ExtensionFramework.Framework.ToolBarItemDisplayStyle
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | Text | テキストのみ | 
| `1` | Image | イメージのみ | 
| `2` | ImageAndText | イメージとテキスト | 


## `ToolBarItemInsertPos`

ツールバーに追加するアイテムの挿入先
```csharp
public enum LightningReview.ExtensionFramework.Framework.ToolBarItemInsertPos
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | Before | 兄弟として指定したアイテムの前 | 
| `1` | After | 兄弟として指定したアイテムの後 | 
| `2` | Top | 先頭 | 
| `3` | Bottom | 末尾 | 


## `ToolBarItemSeparatorInsertPos`

ツールバーに追加するアイテムのセパレータの挿入位置
```csharp
public enum LightningReview.ExtensionFramework.Framework.ToolBarItemSeparatorInsertPos
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | None | セパレータなし | 
| `1` | Before | ツールバーに追加するアイテムの直前 | 
| `2` | After | ツールバーに追加するアイテムの直後 | 


## `ToolBarItemType`

ツールバーに追加するアイテムの種類
```csharp
public enum LightningReview.ExtensionFramework.Framework.ToolBarItemType
    : Enum, IComparable, IFormattable, IConvertible

```

Enum

| Value | Name | Summary | 
| --- | --- | --- | 
| `0` | Button | 通常のボタン | 
| `1` | ToggleButton | トグルボタン | 


