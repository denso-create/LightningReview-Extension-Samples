## `ExtensionProfiler`

処理時間を計測する。  using (ExtensionProfiler.StartProfile()) で囲んだ部分を計測する。
```csharp
public class LightningReview.ExtensionFramework.Framework.Diagnostics.ExtensionProfiler
    : IDisposable

```

Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Dispose() | 消滅 | 


Static Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `IApp` | App | ポストするLRのアプリケーション本体 | 
| `Boolean` | IsEnabled | このクラスの機能が有効であるか。 | 


Static Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `IDisposable` | StartProfile(`String` filePath = , `String` memberName = ) | 計測開始する(引数を指定しないことで、呼び出し元の[クラス名].[メンバー名]を出力時の文字列とする) | 
| `IDisposable` | StartProfileWithKey(`String` key) | 計測開始する | 


