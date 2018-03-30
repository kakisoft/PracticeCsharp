# WPF小メモ

## UID
```
コンポーネント一意のキー。
動的に生成する場合は、配置したタイミングで割り振られる。（それまでは空白）
自分で作ってもいいみたい。

```


## 情報検索
silverlight で検索した情報が、そのまま使えたりする。

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
```




