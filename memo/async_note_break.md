## asyc
 * 非同期メソッドには async キーワードを付ける。
 * async void の場合、呼び出し元に awaitは不要
 * async Task の場合、呼び出し元に awaitを記述
 * async Task\<T>　（例：Task\<int>）は、return で intが返る。
 * 非同期メソッドの末尾は「Async」とする（慣習）

```cs
private void Button01_Click(object sender, RoutedEventArgs e)
{
    Button01_ClickAsync(sender, e);
}

private async void Button01_ClickAsync(object sender, RoutedEventArgs e)
{
    await GetHttpResponse();
}

private async Task GetHttpResponse()
{
    var json = "{ \"age\" : 20, \"name\" : \"太郎\"  }";

    using (var client = new HttpClient())
    {
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await client.PostAsync("http://somehost/someapi", content);

        Console.WriteLine(response);
    }
}
```

```cs
private async void Button03_Click(object sender, RoutedEventArgs e)
{
    await Button03_Click_Async(sender, e);
}
private async Task Button03_Click_Async(object sender, RoutedEventArgs e)
{
    await GetHttpResponse03Async();
}
private async Task GetHttpResponse03Async()
{
    var httpClient = new HttpClient();
    var content = new FormUrlEncodedContent(new Dictionary<string, string>{ { "foo", "111" } });
    var response = await httpClient.PostAsync("http://localhost/", content);
}
```

## Task
Taskで取得した値を取り出すには、await構文を使用する。
```cs
string urlContents = await getStringTask;
```
