https://kakisoft.github.io/PracticeCsharp/memo/WPF_xaml_note
<link href="https://kakisoft.github.io/MiscellaneousNotes/mysite/style_kakisoft.css" rel="stylesheet">
# WPF：xaml 

##### （疑問点）
 * Visibility="Hidden" にした時、デザイナからは触れない？

## WPF4.5入門
http://blog.okazuki.jp/entry/2014/12/27/200015

## x:Key ディレクティブ
https://docs.microsoft.com/ja-jp/dotnet/framework/xaml-services/x-key-directive

## x:Name ディレクティブ
https://docs.microsoft.com/ja-jp/dotnet/framework/xaml-services/x-name-directive

## xamlのタグの名前のつけ方
https://mediaforcelabs.g.hatena.ne.jp/coma2/20091007/1255880017    
searchButton    
searchButton_Click    

## UID
```
コンポーネント一意のキー。
動的に生成する場合は、配置したタイミングで割り振られる。（それまでは空白）
自分で作ってもいいみたい。
```

## 名前空間について
```
名前空間は、基本「System.Windows.Controls」

（例：ListView）
System.Object
  System.Windows.Threading.DispatcherObject
    System.Windows.DependencyObject
      System.Windows.Media.Visual
        System.Windows.UIElement
          System.Windows.FrameworkElement
            System.Windows.Controls.Control
              System.Windows.Controls.ItemsControl
                System.Windows.Controls.Primitives.Selector
                  System.Windows.Controls.ListBox
                    System.Windows.Controls.ListView
```

## WPF Window
独立して表示可能な存在、PageやUserControlのホストになる存在。    

## WPF Page
ホスト下で表示し、「進む」「戻る」などのナビゲーションアプリケーションでの使用を前提とした使い方。    
ホストで使用するにはフレームコントロールを経由して使います。    
http://gushwell.ldblog.jp/archives/52335648.html
    

## WPF UserControl
自作コントロール。単体では独立して動作せず、Window内に設置する必要がある。    
自作後、ビルドしないとコントロールを設置出来ない。    
通常コントロールと使用方法は同じ。    
コントロールに固有名詞を設定すれば、メインウィンドウからメソッドの呼び出しも可。    
    
## タグの閉じ方

#### 開始タグと同名で閉じる
```
        <Button x:Name="Close1" Margin="5" Content="Btn" Height="50" FontSize="20">
        </Button>
```
#### 末尾を「  />  」 で閉じる
```
        <Button x:Name="Close2" Margin="5" Content="Btn" Height="50" FontSize="20" />
```

## 大きさの調整
Width、Heightプロパティに固定値を入れた場合、外側のウィンドウの大きさを変更しても、    
コントロールの大きさ(幅または高さ)は変わらない。    
    
Width、HeightプロパティにAutoを入れた場合は、  
外側のウィンドウの大きさに応じてコントロールの大きさが変わる。      
***※HorizontalAlignmentとVerticalAlignmentを消す。（Stretchに設定）***      

### 固定値指定
「Width="100"」というように、数値のみを与えると、固定幅／高さになる。    

### 比率指定
「Width="2*"」というように、数値の後ろにアスタリスクを付けると、比率指定となる。    
```<Grid>```要素自身のサイズ変更に応じて、比率を保ったまま行／列のサイズも変化する。    

### 自動
「Width="auto"」というように、「auto」を指定すると、子要素のサイズに応じて行／列のサイズが自動調整される。    


### rameworkElement.Width プロパティ
デバイスに依存しない単位 (1 単位は 1/96 インチ)     
※絶対的な値

### ディスプレイの解像度
1280×1024    
（横に1280、縦に1024の画素のピクセル）

## コントロールのコピーペースト
全く同じポジションにペーストされるため、一見、動作していないように見えてしまう。

## ウィンドウの追加（既存のファイルから）
```
ソリューションエクスプローラにて右クリック→追加→既存の項目
```
xamlと、それに紐付くcsを追加した場合、Visual Studioのソリューションエクスプローラではツリー構造にならない事がある。    
<プロジェクト名>.csproj を直接編集して対処。
```
    <Compile Include="AddedWindow.xaml.cs">
      <DependentUpon>AddedWindow.xaml</DependentUpon>
    </Compile>
```
 * AddedWindow.xaml
 * AddedWindow.xaml.cs

の組み合わせ。    


## ユーザコントロール：UserControl
コントロールの組み合わせを使い回す。    
http://yujiro15.net/YKSoftware/tips_UserControl.html
    
https://garafu.blogspot.jp/2016/01/wpf-dependencyproperty.html

## ControlTemplate：カスタムテンプレート
ControlTemplateは、コントロールの外観を指定します。 コントロールにControlTemplateがない場合、コントロールはアプリケーションに表示されません。     
https://msdn.microsoft.com/ja-jp/library/system.windows.controls.controltemplate(v=vs.110).aspx
    
https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/controls/customizing-the-appearance-of-an-existing-control

## Gridコントロール
Panelのような、配置に絡んだもの。    
htmlのtableタグに近い感覚。    

## DataGridコントロール
グリッド。    
#### プロパティウィンドウから見た目だけをサクッと編集（ヘッダ・要素の属性）
Columns→(コレクション)→Header

#### プロパティウィンドウから見た目だけをサクッと編集（アイテム）
Items→(コレクション)→ListBoxItemなどを選択→追加    
・・・で行けるのかと思ったけど、変化なし。よく分からん。    
パッと見の体裁を整えるだけでもクラスを定義してバインディングせんといけんの？    
ってか、１行に複数カラムを設定できんのかな。    

## 枠線
BorderBrush で枠の色を設定、BorderThickness で枠の太さを設定    
（Label、TextBoxなど）    

PanelやGridの場合、Borderコントロールを配置。      
といっても、Borderコントロールの内部にコントロールを定義するわけでなく、ヘッダあたりにでも定義しておけばOK。
```xml
（例）
</Grid.ColumnDefinitions>

<Border Grid.ColumnSpan="3"  BorderBrush="Black" BorderThickness="1.5" />

<Button   Grid.Row="0" Grid.Column="0" Margin="5,0" Content="0-0" />
<Button   Grid.Row="0" Grid.Column="1" Margin="5,0" Content="0-1" />
```
他に、GroupBox上に載せる方法でも良さげ。    

## パネル系の継承関係
System.Windows.Controls.Panel    
┗System.Windows.Controls.StackPanel    
┗System.Windows.Controls.DockPanel    
┗System.Windows.Controls.WrapPanel    
┗System.Windows.Controls.Grid    

## StackPanel：縦 or 横に並べる（デフォルトは縦）
Orientation="Horizontal" or "Virtual"    
FlowDirection="RightToLeft"  or  "LeftToRight"    
　    
## WrapPanel：横に並べて、自動で折り返す
方向は指定可能。    
　    
## DockPanel：横に並べて、折り返さない
横に並べ続けると、見えなくなる事も。    
複雑なレイアウトが作れる。    
http://ufcpp.net/study/dotnet/wpf_container.html
    
配置例    
```xml
<DockPanel
  Width="200" Height="200"
  Background="LightGray"
  >

  <TextBox Text="1" Background="#ffffcc" DockPanel.Dock="Top"    />
  <TextBox Text="2" Background="#ffccff" DockPanel.Dock="Left"    />
  <TextBox Text="3" Background="#ccffff" DockPanel.Dock="Right"    />
  <TextBox Text="4" Background="#ffcccc" DockPanel.Dock="Bottom"    />
  <TextBox Text="5" Background="#ccffcc" DockPanel.Dock="Left"    />
  <TextBox Text="6" Background="#ccccff" DockPanel.Dock="Right"    />

</DockPanel>
```

## ★配置に関する個人的見解★
拡大・縮小する事を考えるなら、Panel系よりもGridがいい。        
伸縮するエリア（特にグリッド。テキストエリアも）を内包する場合は、絶対にGridがいい。        
てか、基本Grid。    
DockPanelみたく、小さくしてもコントロールが崩れずにする時くらい？    
　    
## 固定配置とフロート配置
InlineUIだと、ポジションを指定した配置が出来ない。

```xml
<Grid>
    <TextBlock >
        <InlineUIContainer>
            <Button Content="Button1" HorizontalAlignment="Left" Height="32" VerticalAlignment="Top" Width="95"/>
        </InlineUIContainer>
    </TextBlock>
    <Button Content="Button2" HorizontalAlignment="Left" Height="32" Margin="20,66,0,0" VerticalAlignment="Top" Width="95"/>
    <Button Content="Button3" HorizontalAlignment="Left" Height="32" Margin="50,149,0,0" VerticalAlignment="Top" Width="95"/>
</Grid>
```

## Margin
```xml
   左      上     右       下
（Left）（Top）（Right）（Bottom）
<Button Margin="-10,-40,30,10"
<Button Margin="110,-40,30,10"  Content="当日" HorizontalAlignment="Left" Height="40" VerticalAlignment="Top" Width="100"/>
```

## ラジオボタン
StackPanel に配置。    
もしくは、GroupBox → Grid とか。
```xml
<GroupBox Header="GroupBox" HorizontalAlignment="Left" Height="64" Margin="10,342,0,0" VerticalAlignment="Top" Width="308">
    <Grid HorizontalAlignment="Left" Height="29" Margin="20,5,0,0" VerticalAlignment="Top" Width="243">
        <RadioButton Content="RadioButton1" HorizontalAlignment="Left" Margin="11,5,0,0" VerticalAlignment="Top"/>
        <RadioButton Content="RadioButton2" HorizontalAlignment="Left" Margin="118,4,0,0" VerticalAlignment="Top"/>
    </Grid>
</GroupBox>
```

## トグルボタン
ツールボックスに表示されない？      
⇒よく調べたら RadioButtonやCheckboxのベースクラスで、AndroidのwidgetでのToggleButtonとは全然違うみたい。
```xml
<ToggleButton x:Name="ToggleButtonName1" Content="ToggleButton" HorizontalAlignment="Left"
              Margin="10,10,0,0" VerticalAlignment="Top" IsChecked="True"/>
```

## トグル風ボタン
```xml
        <StackPanel x:Name="StackPanel1" HorizontalAlignment="Left" Height="41" Margin="105,190,0,0" VerticalAlignment="Top" Width="255" RenderTransformOrigin="1.87,0.5">
            <RadioButton Style="{StaticResource {x:Type ToggleButton}}" x:Name="ToggleStyleButton1" Content="トグル風ボタン１" Height="40" Width="100" HorizontalAlignment="Left" VerticalAlignment="Top" IsChecked="True"/>
            <RadioButton Style="{StaticResource {x:Type ToggleButton}}" x:Name="ToggleStyleButton2" Content="トグル風ボタン２" Height="40" Width="100" Margin="70,-40,0,0"/>
        </StackPanel>
```

## 文字の中央揃え

並べ替え：「カテゴリ」
では表示されない？（「名前」or「ソース」なら表示される。）

```xml
<TextBox x:Name="TerminalNo" HorizontalAlignment="Left" Height="35" Margin="161,513,0,0" TextWrapping="Wrap" VerticalAlignment="Top" Width="142" Text="（端末番号）" FontSize="14" VerticalContentAlignment="Center"/>
```
ソースから変更
```cs
TerminalNo.VerticalContentAlignment = VerticalAlignment.Bottom;
```
※***VerticalAlignment***ではない  

## Grid
htmlのtableみたいな感覚？  
Grid.ColumnSpanで連結が出来たりする。  
```xml
        <Grid Grid.ColumnSpan="4" Margin="10,10,10,10">
            <Grid.RowDefinitions>
                <RowDefinition Height="60" />
                <RowDefinition Height="60" />
                <RowDefinition Height="60" />
                <RowDefinition Height="*"/>
            </Grid.RowDefinitions>

            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="70" />
                <ColumnDefinition Width="70" />
                <ColumnDefinition Width="70" />
                <ColumnDefinition Width="70" />
                <ColumnDefinition Width="*" />
            </Grid.ColumnDefinitions>

            <Button Content="btn1-1" Grid.Row="1" Grid.Column="1" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn1-2" Grid.Row="1" Grid.Column="2" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn1-3" Grid.Row="1" Grid.Column="3" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn1-4" Grid.Row="1" Grid.Column="4" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>

            <Button Content="btn2-1" Grid.Row="2" Grid.Column="1" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn2-2" Grid.Row="2" Grid.Column="2" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn2-3" Grid.Row="2" Grid.Column="3" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
            <Button Content="btn2-4" Grid.Row="2" Grid.Column="4" Grid.RowSpan="1" FontSize="12" Width="50" Height="20" Background="#FF2BE2C1"/>
        </Grid>
```
```xml
        <StackPanel HorizontalAlignment="Left" Height="41" Margin="105,190,0,0" VerticalAlignment="Top" Width="255" RenderTransformOrigin="1.87,0.5">
            <Button Content="当日" Height="40" Width="100" HorizontalAlignment="Left" VerticalAlignment="Top"/>
            <Button Content="当日" Height="40" Width="100" Margin="70,-40,0,0"/>
        </StackPanel>
```

## Grid：比率を指定して配置
コントロールの幅や高さを画面サイズのパーセントで指定するには？    
http://www.atmarkit.co.jp/ait/articles/1505/20/news026.html
```
<Grid ……省略……>
  <Grid.ColumnDefinitions>
    <ColumnDefinition Width="0.6*"/>
    <ColumnDefinition Width="0.4*"/>
  </Grid.ColumnDefinitions>
  <Image Source="Assets/hayashi_09.JPG" Stretch="UniformToFill" />
  <TextBlock Grid.Column="1" TextWrapping="Wrap" FontSize="30">
    ……省略（長い文字列）……
  </TextBlock>
</Grid>
```
フレキシブルに対応するには、この方法が良さそう。    

## HorizontalAlignment プロパティ
https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/advanced/alignment-margins-and-padding-overview

## リキッド レイアウト (liquid layout) 
表示領域のサイズによって動的に表示方法が最適化されるようなレイアウト。    
https://sakapon.wordpress.com/2015/03/27/xaml-layout/
    
#### (1) Grid
Grid では、ColumnDefinitions プロパティおよび RowDefinitions プロパティにより、各行・列の幅を指定できます。    
固定値のほか、他の行・列との相対値 (1:2 にする場合など) や内部のコンテンツの幅 (Auto) も指定できます。    

#### (2) ScrollViewer
ScrollViewer を利用すれば、スクロールにより全体を表示させることができます。     
コレクション データを扱う場合は、ScrollViewer と WrapPanel を組み合わせて使うとよいでしょう。     
ちなみに ScrollViewer は、既定で縦スクロールバーが有効、横スクロールバーが無効に設定されています。    

#### (3) Viewbox
Viewbox は、表示領域に合わせて内部のコンテンツを伸縮させることにより、元のレイアウトを保持します。    
最も手っ取り早い方法かもしれません。    

#### (4) 最大値・最小値の指定
Viewbox のような伸縮させるコントロールでは、既定では無制限にコンテンツが拡大・縮小してしまいます。        
したがって、サイズの最大値・最小値を指定する方法も有効です。         
※Viewboxは文字の大きさが拡大する    

## プロパティウィンドウについてのメモ
デザイナ画面のプロパティ一覧には、
「Grid.Row」「Grid.RowSpan」といった、親のコントロールに依存する値もリストアップされる。便利。

## リソース
複数のUI要素で1つのオブジェクトを共有するために、リソースという仕組みを持っている。      
『WPFの「リソース、スタイル、テンプレート」を習得しよう。』    
http://www.atmarkit.co.jp/ait/articles/1009/07/news096.html

## ListBoxとListView
```
ListBox
┗ListView
```
正直、調べても違いがよう分からん。   
以下、自分の印象。
### ListBox
複数選択できるコンボボックスのスタンダードスタイル。

### ListView
Androidのwidgetみたいなもん？    
ListBoxよりも簡素化されて、機能も絞られているみたいな感じ？    

## Manipulation系のプロパティ
http://www.atmarkit.co.jp/ait/articles/1103/01/news124.html
 * ManipulationStarted： 
     * ユーザーがタッチ操作を開始したときに発生する。
 * ManipulationStarting： 
     * タッチ操作可能なUI要素（＝IsManipulationEnabledプロパティの値が「true」）に対してユーザーがタッチ操作を開始したときに発生する。<br>
       　⇒IsEnabledがTrueの時のみ発生する、という解釈でＯＫなのか？
 * ManipulationInertiaStarting： 
     * ユーザーが慣性操作（＝勢いよく指を動かしたときに、しばらく慣性的にManipulationDeltaイベントが起きる）を開始したときに発生する。
 * ManipulationDelta：
     * ユーザーが指を動かしてタッチ操作に変化が生じたときに発生する。
 * ManipulationCompleted： 
     * ユーザーがタッチ操作を終えたときに発生する。
 * ManipulationBoundaryFeedback： 
      * 操作対象のUI要素がタッチ操作可能な範囲の境界に到達したときに発生する。

## ObservableCollection 
https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/data/how-to-create-and-bind-to-an-observablecollection
    
ObservableCollection<T>クラスは、項目が追加または削除されたときに通知を提供するコレクション クラスです。    
（要バインド）

## TextBlock
実はラベルっぽいもので、エンドユーザは編集できない。HTML仕様に改良したもの？
が、テキストブロックの中にテキストボックスや、ボタンなどコントロールを配置できる。

## CheckBox
CheckedChanged は無い。    
Checked イベントと Unchecked イベントを使う。    
Checked はチェック時、Unchecked はチェックが外れた時しかイベント起きない。


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

## TextBox 縦位置中央揃え
```xml
VerticalContentAlignment="Center"
```
