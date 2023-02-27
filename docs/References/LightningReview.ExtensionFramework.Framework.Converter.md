## `NullToVisibleConverter`

オブジェクトがnullか否かと、Visibilityを変換する  オブジェクトがnullの場合、Visible。nullではない場合、Collapsed。
```csharp
public class LightningReview.ExtensionFramework.Framework.Converter.NullToVisibleConverter
    : IValueConverter

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Object` | Convert(`Object` value, `Type` targetType, `Object` parameter, `CultureInfo` culture) | オブジェクトがnullか否かと、Visibilityを変換する | 
| `Object` | ConvertBack(`Object` value, `Type` targetType, `Object` parameter, `CultureInfo` culture) | OneWayのため実装しない | 


## `VisibleConverter`

bool値とVisibilityの変換を行うコンバータ  trueとVisible、falseとCollapsedの相互変換を行う
```csharp
public class LightningReview.ExtensionFramework.Framework.Converter.VisibleConverter
    : IValueConverter

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `Object` | Convert(`Object` value, `Type` targetType, `Object` parameter, `CultureInfo` culture) | bool値をVisibilityに変換する  true:Vislble, false:Collapsed | 
| `Object` | ConvertBack(`Object` value, `Type` targetType, `Object` parameter, `CultureInfo` culture) | VisibilityをBool値に変換する  Visible:true, Collapsed:false | 


