## `DialogViewModelBase`

ダイアログ用のビューモデルのベースクラス
```csharp
public class LightningReview.ExtensionFramework.Framework.MVVM.DialogViewModelBase
    : ViewModelBase, INotifyPropertyChanged

```

Properties

| Type | Name | Summary | 
| --- | --- | --- | 
| `ICommand` | AcceptCommand | OKボタン押下時のコマンド | 
| `ICommand` | CancelCommand | キャンセルボタン押下時のコマンド | 


Methods

| Type | Name | Summary | 
| --- | --- | --- | 
| `void` | Accept() | OKボタン押下時の処理  既定ではWindow.DialogResultにTrueが設定されます | 
| `Boolean` | CanAccept() | OK可能か | 
| `Boolean` | CanCancel() | キャンセル可能か | 
| `void` | Cancel() | キャンセルボタン押下時の処理  既定ではWindow.DialogResultにFalseが設定されます | 


