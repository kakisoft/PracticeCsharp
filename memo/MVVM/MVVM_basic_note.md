```
M ← VM ← V

 * ViewはVMを知っている
 * VMはModelを知っている

VとVMは、1:N だけど、
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
であったとしても、右辺にはプロパティを記述。
```

