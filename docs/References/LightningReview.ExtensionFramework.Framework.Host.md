## `ToolBarItemManager`

ツールバーに追加するアイテムを登録したり、UIにバインドするクラス
```csharp
public class LightningReview.ExtensionFramework.Framework.Host.ToolBarItemManager

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IHostApp` | App | アプリケーション | 
| `IDictionary<String, ToolBar>` | ToolBars | ツールバーの一覧 | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | BindUI(`String` location, `UIElement` element, `ToolBar` toolBar) | ツールバーに追加するアイテムをUIにバインドする | 
| `ToolBar` | GetToolBar(`String` location) | locationのツールバーを取得する | 
| `Boolean` | IsValidLocation(`String` location) | 有効なロケーションか返す | 
| `void` | RegisterLocation(`String` location) | 有効なロケーションを登録する | 
| `ToolBarItemBuilder` | RegisterToolBarItem(`ToolBarItemManager` toolBarItemManager, `IHostApp` app, `IExtensionBase` extension) | ツールバーに追加するアイテムのビルダーを作成する。 | 


