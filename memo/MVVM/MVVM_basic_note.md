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
