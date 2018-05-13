# バインディングについての自分なりの解釈

## １．ルート（フォームのthis）にDataContextを配置（newで生成）し、共有する
⇒追記：別にルートじゃなくてもいい。
```
（例）
stackpanel.DataContext = HogeObject;
```
コードにて、
```cs
this.DataContext = _obj;
```
でセット。    
    
xaml側からは
```xml
Text="{Binding Name}"
```
といった感じで紐付け。

### 注意点
View編集→Model自動更新　はＯＫだが、    
Model変更→View自動更新　は出来ない事が。    
    
バインディングのモードが原因。    
### BindingのMode
|  モード          |    説明                                              |
|:-----------------|:-----------------------------------------------------|
|  OneWay          |  ソースからターゲットへの一方通行の同期になります。  |
|  TwoWay          |  ソースとターゲットの双方向の同期になります。        |
|  OneWayToSource  |  ターゲットからソースへの一方通行の同期になります。  |
|  OneTime         |  ソースからターゲットへ初回の一度だけ同期されます。  |

★ソース→コントロール　への動機は、ソースとなるオブジェクトがINotifyPropertyChangedを実装（インプリメント）してプロパティの変更通知を実装している必要がある。
```
（例）
public class Person : INotifyPropertyChanged
```
ただし、テキストボックスなどの一部のコントロールでは、そこまでしなくてもできるみたい。    
https://water2litter.net/gin/?p=1401

・・・と思ったけど、上手く行かん。何でだ。      
TextBlock は、双方向バインディングの設定だとか INotifyPropertyChangedの実装とかは不要で、View側に通知される？

***（参考サイト）***    
http://blog.okazuki.jp/entry/2014/09/15/201110    
http://blog.okazuki.jp/entry/2016/09/15/214319    

### 正しいと思うけど、エラーが出る（名前空間が認識されないなど）
とりあえずリビルド。それで行ける事がある。    

## ２．Window.Resourcesにて定義

____________________________________________________________________

## WPFの「データ・バインディング」を理解する 
http://www.atmarkit.co.jp/ait/articles/1010/08/news123.html
```
{Binding X}
{Binding Path=X}
```
## バインディングには２種類ある？

 * thisに設置して、共有リソースのように使う
 * DataGridに流し込むデータ（ItemsSource="{Binding}"）

## 今さら入門するMVVMに必要な技術要素
http://blog.okazuki.jp/entry/2016/09/15/214319    
Xamarin.Formsでは、BindableObjectで定義されたBindingContextプロパティに設定されたオブジェクトがBindingのPathの起点になります。    
UWPでは、FrameworkElementで定義されたDataContextプロパティに設定されたオブジェクトがBindingのPathの起点になります。
