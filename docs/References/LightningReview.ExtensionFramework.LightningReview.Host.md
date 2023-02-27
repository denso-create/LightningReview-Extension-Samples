## `IMetaData`

エンティティのメタデータを取得・更新するインターフェイス
```csharp
public interface LightningReview.ExtensionFramework.LightningReview.Host.IMetaData

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `Boolean` | Encrypted | 暗号化されているか | 
| `String` | Key | キー | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `T` | GetValue(`T` defaultValue = null, `Boolean` decrypt = False) | 型を指定して値を取得する | 
| `void` | SetValue(`Object` value, `Boolean` encrypt = False) | 値を設定する | 


## `RunScriptResult`

スクリプトの実行結果オブジェクトです。
```csharp
public class LightningReview.ExtensionFramework.LightningReview.Host.RunScriptResult

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `String` | ErrorMessage | エラーメッセージを取得または設定します。 | 
| `Boolean` | IsSuccess | 実行に成功したかどうかを取得または設定します。 | 
| `Object` | ReturnValue | 戻り値を取得または設定します。 | 


