## Async および Await を使用した非同期プログラミング 
https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/index    
（サンプルソース付き）


## async
非同期であることを指定します。     
の修飾子が使用されているメソッドまたは式を、"非同期メソッド" と呼びます。    
https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/async


## Task クラス
非同期操作を表します。


## Taskを極めろ！async/await完全攻略
https://qiita.com/acple@github/items/8f63aacb13de9954c5da


### 1000ミリ秒待機するタスクの完了を待ち、その後"Done!"を出力する、というタスク
```cs
async Task AsyncMethod()
{
    await Task.Delay(1000); // 1000ミリ秒待機するという仕事の完了を待ち、
    WriteLine("Done!"); // "Done!"をコンソールに出力する
} // という、「一つのTask」を表す。
```

 * シグネチャにasyncを付けたメソッドのことを「非同期メソッド」と呼ぶ。
 * 非同期メソッドは、awaitキーワードを使えるようになる。
 * awaitは、「指定したTaskの完了を待つ」「そして、その結果を取り出す」事ができる。
 * 非同期メソッドの戻り値は必ずTask/Task\<T>になる。

非同期メソッドとは、複数の「タスク」の実行順序などを記述した「一つのタスク」と見なす事ができる。
（作業手順書のようなもの）

```cs
var task = Task.Run(() =>
{
    MethodA();
    MethodB();
});
```
Task.Runの概念を、一言で言えば
「同期的な一連の処理を、一つのタスクとみなす」    
だそうな。


