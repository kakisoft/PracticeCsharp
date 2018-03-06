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
