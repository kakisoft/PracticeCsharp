https://kakisoft.github.io/PracticeCsharp/memo/WPF_xaml_note
<link href="https://kakisoft.github.io/MiscellaneousNotes/mysite/style_kakisoft.css" rel="stylesheet">
# WPF：xaml 

##### （疑問点）
 * Visibility="Hidden" にした時、デザイナからは触れない？

## WPF4.5入門
http://blog.okazuki.jp/entry/2014/12/27/200015

## コントロールのコピーペースト
全く同じポジションにペーストされるため、一見、動作していないように見えてしまう。

## ユーザコントロール：UserControl
コントロールの組み合わせを使い回す。    
http://yujiro15.net/YKSoftware/tips_UserControl.html
    
https://garafu.blogspot.jp/2016/01/wpf-dependencyproperty.html

## ControlTemplate：カスタムテンプレート
コントロールの外観を変える。    
https://msdn.microsoft.com/ja-jp/library/system.windows.controls.controltemplate(v=vs.110).aspx
    
https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/controls/customizing-the-appearance-of-an-existing-control

## Gridコントロール
といった、配置に絡んだもの。

## DataGridコントロール
グリッド。    
ヘッダの名称は、Column→Header

## Panel系メモ
枠線（Border）を設定することはできなさそう。    
Borderコントロール上に配置する方法もあったけど、GroupBox上に載せる方が良さげ。    

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
## HorizontalAlignment プロパティ
https://docs.microsoft.com/ja-jp/dotnet/framework/wpf/advanced/alignment-margins-and-padding-overview

## リキッド レイアウト (liquid layout) 
表示領域のサイズによって動的に表示方法が最適化されるようなレイアウト。

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


