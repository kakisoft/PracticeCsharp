## 参照
https://msdn.microsoft.com/ja-jp/library/system.windows.controls.listview(v=vs.110).aspx
```
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

## リストビューをクリア
myListView.Items.Clear();


## アイテムセット
```
myListView01.Items.Add(dispElementString);


※ヘッダの設定をしていないと、おかしな表示になる
myListView01.Items.Add(new string[] { "1", "2", "3" });

```
```xml
<ListView x:Name="myListView01" Width="150">
    <ListView.View>
        <GridView>
            <GridView.ColumnHeaderContainerStyle>
                <Style TargetType="GridViewColumnHeader">
                    <Setter Property="Visibility" Value="Collapsed" />
                </Style>
            </GridView.ColumnHeaderContainerStyle>


            <GridViewColumn Header="id"   DisplayMemberBinding="{Binding Id}" />
            <GridViewColumn Header="text" DisplayMemberBinding="{Binding DispText}" />
        </GridView>
    </ListView.View>
</ListView>
```

```cs
TextTypeControl textElement01 = new TextTypeControl();
textElement01.Id = 1;
textElement01.DispText = "要素１";
myListView01.Items.Add(textElement01);
```




## ヘッダ非表示
標準では無いみたい。
```
<ListView x:Name="myListView01" Width="150">
    <ListView.View>
        <GridView>
            <GridView.ColumnHeaderContainerStyle>
                <Style TargetType="GridViewColumnHeader">
                    <Setter Property="Visibility" Value="Collapsed" />
                </Style>
            </GridView.ColumnHeaderContainerStyle>
            
            <GridViewColumn Header="id"   DisplayMemberBinding="{Binding [0]}" />
            <GridViewColumn Header="text" DisplayMemberBinding="{Binding [1]}" />
        </GridView>
    </ListView.View>
</ListView>
```


#### その他 雑記
```
SubItems って何者？
```

