# WPF小メモ

## UID
```
コンポーネント一意のキー。
動的に生成する場合は、配置したタイミングで割り振られる。（それまでは空白）
自分で作ってもいいみたい。

```

## プロパティもオブジェクトとして扱える。
```cs
（例）

Setter settep = new Setter();
settep.Property = StyleProperty;
settep.Value = typeof(ToggleButton);
style2.Resources. = settep;


（例２）
Style style = new Style(typeof(TextBox));

// 依存プロパティ識別用のフィールドを使って設定する。
style.Setters.Add(new Setter(TextBox.WidthProperty, 180.0));
style.Setters.Add(new Setter(TextBox.HeightProperty, 30.0));
style.Setters.Add(new Setter(TextBox.BackgroundProperty, new SolidColorBrush(Colors.Yellow)));
style.Setters.Add(new Setter(TextBox.ForegroundProperty, new SolidColorBrush(Colors.Blue)));


（例）
// 回転ハンドル用テンプレート作成
FrameworkElementFactory fefEllpse = new FrameworkElementFactory();
fefEllpse.Type = typeof( System.Windows.Shapes.Ellipse );
fefEllpse.SetValue( FrameworkElement.WidthProperty, DOB_10 );
```




