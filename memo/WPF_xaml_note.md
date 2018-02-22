# WPF：xaml 

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

##### x
```
・ツールボックス：ToggleButtonの表示
・Visibility="Hidden" にした時、デザイナからは触れない？
```

