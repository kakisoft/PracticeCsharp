## async
非同期であることを指定します。     
の修飾子が使用されているメソッドまたは式を、"非同期メソッド" と呼びます。    
https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/async


## Async および Await を使用した非同期プログラミング 
https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/index    
（サンプルソース付き）

## Task クラス
非同期操作を表します。

## partial（部分クラスと部分メソッド）
https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods
    
クラス、インターフェイス、メソッドの定義を、複数のソースに分割できる。    
（コンパイル時に結合）
```cs
public partial class Employee
{
    public void DoWork()
    {
    }
}

public partial class Employee
{
    public void GoToLunch()
    {
    }
}
```
## throw（例外をスローする）
例外を明示的に発生させる事。 
例外が投げられると、正常動作部の処理は中断され、例外処理部が呼び出される。
```cs
throw 例外クラスのインスタンス

（例）
throw new FormatException();
```
http://ufcpp.net/study/csharp/oo_exception.html
