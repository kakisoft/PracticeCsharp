```
M ← VM ← V

 * ViewはVMを知っている
 * VMはModelを知っている

VとVMは、1:N でも書けるけど、
1:1 が望ましい。
（Nameを指定する必要が出てくるため）
```


```
RelayCommand は、ICommand を実装している。

プロパティを双方向にするには、INotifyPropertyChanged が必要だったが、
コマンドを検知するには、ICommand が必要となる。
んで、ビハインド側に、

「Command="{Binding Path=_cmdNone}"」

みたいなバインディング記述になる。
```

```
DataContext
　⇒プロパティから値を拾う



バインディングできるのは、プロパティのみ（と考えていい。）
なので、Command="{Binding OkCommand}"
であったとしても、右辺にはプロパティを記述。　※メソッドではない。
```

```
・M
データ（≒テーブル）の管理

・V
ユーザインターフェース

・VM
Model から View へ出力データを渡す
View から Model へ入力データを渡す
```
https://docs.microsoft.com/ja-jp/dotnet/standard/cross-platform/using-portable-class-library-with-model-view-view-model

```
CommandParameter
　⇒ ViewModelが知らないオブジェクトに対して、何かしらの働きかけをする場合に使用する。


別に使わないでもいい。というか使わないでも十分解決できる。
```
