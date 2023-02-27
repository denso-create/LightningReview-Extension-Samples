## `DateTimePicker`

日付設定用コントロール
```csharp
public class LightningReview.ExtensionFramework.Framework.Controls.DateTimePicker
    : UserControl, IResource, IAnimatable, IInputElement, IFrameworkInputElement, ISupportInitialize, IHaveResources, IQueryAmbient, IAddChild, INotifyPropertyChanged, IComponentConnector

```

Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| `ListView` | m_CalendarList |  | 
| `Popup` | m_CalendarPopup |  | 
| `Button` | m_ClearButton |  | 
| `TextBlock` | m_DateTextBlock |  | 
| `Button` | m_DateTimeSettingButton |  | 
| `TextBlock` | m_DateTimeTextBlock |  | 
| `TextBlock` | m_NullValueTextBlock |  | 
| `Button` | m_TodayButton |  | 


Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IList` | CalendarCollection | 日付のコレクション（カレンダー表示のためのコレクション） | 
| `Boolean` | CanClear | 日付のクリアが可能かどうかを設定・取得する  (これは依存関係プロパティです) | 
| `Nullable<DateTime>` | MonthFirstDay | 月の始めの日 | 
| `String` | NullValueText | 設定している日付がnullである場合に表示するテキスト | 
| `Nullable<DateTime>` | SelectedDateTime | 設定している日付を設定・取得する  （これは依存関係プロパティです） | 


Events

| Type | Name | Summary | 
| --- | --- | --- | 
| `PropertyChangedEventHandler` | PropertyChanged | プロパティ変更通知イベント | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | InitializeComponent() | InitializeComponent | 
| `void` | OnPropertyChanged(`String` propertyName = null) | プロパティ変更を通知する | 


Static Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| `DependencyProperty` | CanClearProperty | 日付のクリアが可能かどうかを設定・取得する | 
| `DependencyProperty` | NullValueTextProperty | 設定している日付がnullである場合に表示するテキスト | 
| `DependencyProperty` | SelectedDateTimeProperty | 設定している日付を設定・取得する | 


## `ToolBarButton`

ToolBarに追加するボタン
```csharp
public class LightningReview.ExtensionFramework.Framework.Controls.ToolBarButton
    : Button, IResource, IAnimatable, IInputElement, IFrameworkInputElement, ISupportInitialize, IHaveResources, IQueryAmbient, IAddChild, ICommandSource, IComponentConnector

```

Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| `Image` | m_Image |  | 
| `TextBlock` | m_TextBlock |  | 


Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `ToolBarItemDisplayStyle` | DisplayStyle | 表示スタイル | 
| `ImageSource` | Image | イメージ | 
| `String` | Text | テキスト | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | InitializeComponent() | InitializeComponent | 


## `ToolBarToggleButton`

ToolBarに追加するトグルボタン
```csharp
public class LightningReview.ExtensionFramework.Framework.Controls.ToolBarToggleButton
    : ToggleButton, IResource, IAnimatable, IInputElement, IFrameworkInputElement, ISupportInitialize, IHaveResources, IQueryAmbient, IAddChild, ICommandSource, IComponentConnector

```

Fields

| Type | Name | Summary | 
| --- | --- | --- | 
| `Image` | m_Image |  | 
| `TextBlock` | m_TextBlock |  | 


Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `ToolBarItemDisplayStyle` | DisplayStyle | 表示スタイル | 
| `ImageSource` | Image | イメージ | 
| `String` | Text | テキスト | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | InitializeComponent() | InitializeComponent | 


