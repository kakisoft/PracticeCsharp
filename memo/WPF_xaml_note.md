# WPF：xaml 

### コントロールのコピーペースト
全く同じポジションにペーストされるため、一見、動作していないように見えてしまう。

### 固定配置とフロート配置
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

### ラジオボタン
GroupBox → Grid の上に配置

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
'''xml
<ToggleButton x:Name="ToggleButtonName1" Content="ToggleButton" HorizontalAlignment="Left"
              Margin="10,10,0,0" VerticalAlignment="Top" IsChecked="True"/>
'''

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
※VerticalAlignmentではない  

### Grid
htmlのtableみたいな感覚？  
Grid.ColumnSpanで連結が出来たりする。  
```
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




##### （疑問点）
```
・ツールボックス：ToggleButtonが表示されない？
・Visibility="Hidden" にした時、デザイナからは触れない？
```

