using System;
using DotinstallNamespace;
using System.Collections.Generic;
using System.Linq;

/*
  comment
  
## ? 演算子（三項条件演算子）
//condition が trueなら first_expressionが、falseなら second_expressionが返る。
condition ? first_expression : second_expression;  

## ?? 演算子（null 合体演算子）
//nullの場合、右側の値を返す
 int y = x ?? -1;
*/

//======< Sample01 >=====
public class Customer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool IsMarried { get; set; }
}

//==============================
//          クラス
//==============================
class User {
  private static int count = 0;
  public string name;

  //--------------------
  //   コンストラクタ
  //--------------------
  public User(string name) {
    User.count++;
    this.name = name;
  }
  // public User() { // オーバーロード
  //   this.name = "nobody";
  // }
  public User(): this("nobody") {
  }
  
  public virtual void SayHi() {//オーバーライドするには、virtual宣言が必要。
    // Console.WriteLine($"hi {this.name}");
    Console.WriteLine($"hi {name}"); //C# 6 以降。$を先頭に着けると、直接文字列を記述できる。
  }

  public static void GetCount() {
    Console.WriteLine($"# of instances: {count}");//System.console.WriteLine
  }
}

//==============================
//           継承
//==============================
//※デフォルトでは、コンストラクタは継承されない。
//↓親のコンストラクタを使用している。
class AdminUser: User {
  public AdminUser(string name): base(name) {
  }
  public void SayHello() {
    Console.WriteLine($"hello {name}");
  }
  public override void SayHi() { // override
    Console.WriteLine($"[admin] hi {name}");
  }
}

//==============================
//        プロパティ
//==============================
class Staff {
  private string name = "me!";
  // プロパティ
  public string Name {
    get { return this.name; } // getter
    set {
      if (value != "") {
        this.name = value;
      }
    } // setter
  }
  public string Post { get; set; } = "None";
}

//==============================
//        インデクサ
//==============================
class Team {
  private string[] members = new string[3];
  public string this[int i] {
    get { return this.members[i]; }
    set { this.members[i] = value; }
  }
}

//==============================
//        抽象クラス
//==============================
abstract class Invader {
  public abstract void SayHi();
}

class Japanese: Invader {
  public override void SayHi() {
    Console.WriteLine("こんにちは！");
  }
}

class American: Invader {
  public override void SayHi() {
    Console.WriteLine("hi!");
  }
}

//==============================
//        インターフェース
//==============================
interface ISharable {
  void Share();
}

class Partner: ISharable {
  public void Share() {
    Console.WriteLine("now sharing...");
  }
}

//==============================
//      ジェネリック
//==============================
class MyData<T> {
  public void GetThree(T x) {
    Console.WriteLine(x);
    Console.WriteLine(x);
    Console.WriteLine(x);
  }
}
//Genericを使用しない場合
class MyInteger {
  public void GetThree(int x) {
    Console.WriteLine(x);
    Console.WriteLine(x);
    Console.WriteLine(x);
  }
}

//==============================
//       名前空間
//==============================
namespace DotinstallNamespace {
  class Player {
    public void SayHi() {
      // Console.WriteLine("hi!");
      System.Console.WriteLine("hi!");
    }
  }
}

//==============================
//         構造体
//==============================
struct Point {
  public int X { get; }
  public int Y { get; }
  public Point(int x, int y) {
    X = x;
    Y = y;
  }
  public void GetInfo() {
    Console.WriteLine($"({X}:{Y})");
  }
}

//==============================
//         列挙型
//==============================
enum Direction {
  Stay = 0,
  Right = 1,
  Left = -1
}

enum ProductCategory {
  DailyGoods,     // 0
  BrokenArticle,  // 1
  ArtWork         // 2
}

//==============================
//          例外
//==============================
class MyException: Exception {
  public MyException(string msg): base(msg) {

  }
}

class MyExceptionPractice{
  public static void Div(int a, int b) {
    try {
      if (b < 0) {
        // 例外
        throw new MyException("not minus!");
      }
      Console.WriteLine(a / b);
    } catch (DivideByZeroException e) {
      Console.WriteLine(e.Message);
    } catch (MyException e) {
      Console.WriteLine(e.Message);
    } finally {
      Console.WriteLine(" -- end -- ");
    }
  }
}

//==============================
//          イベント
//==============================
delegate void MyEventHandler();
class MyButton {
  public event MyEventHandler MyEvent;　// eventを付けると、MyEventは、 このクラス(MyButton)からのみ実行可能という制限をつけることができます。
  public void OnClicked() {
    if (MyEvent != null) {
      MyEvent();
    }
  }
}


/////////////////////////////////////
//           
/////////////////////////////////////
class MyApp {

  static void SayHi1() {
    Console.WriteLine("hi!");
  }
  static string SayHi2() {
    return "hi!";
  }
  static string SayHi3() => "hi!";

  static void SayHi4(string name, int age = 23) {
    Console.WriteLine($"hi! {name} ({age})");
  }

  //==============================
  //          デリゲート
  //==============================
  //デリゲートがある事で、メソッドを変数として扱える。
  delegate void MyDelegate(); // 引数無し
  static void SayHiFromDeligater() => Console.WriteLine("hi!(From Delegate)"); //デリゲート登録するメソッド
  static void SayHelloFromDeligater() => Console.WriteLine("hello!(From Delegate)");
  //↑と同義
  // static void SayHelloFromDeligater() {
  //   Console.WriteLine("hi!");
  // }

  ////////////////////
  //           
  ////////////////////
  static void Main() {

    //変数
    string msg = "Hello World";
    Console.WriteLine(msg);

    //定数
    const string CONST_MSG = "CONST MESSAGE";
    Console.WriteLine(CONST_MSG);

    //==============================
    //            型
    //==============================

    // 文字列、文字
    // string, char
    string s = "hello";
    char c = 'a';

    // 整数値
    // byte, short, int, long
    int i1 = 100;

    // 浮動小数点数
    // float, double
    double d = 52342.34;
    float f = 23.3f;

    // 論理値
    // bool -> true, false
    bool flag1 = true;

    // 型推論
    var m1 = 5; // int
    var n1 = "world"; // string

    Console.WriteLine(s);
    Console.WriteLine(c);
    Console.WriteLine(i1);
    Console.WriteLine(d);
    Console.WriteLine(f);
    Console.WriteLine(flag1);
    Console.WriteLine(m1);
    Console.WriteLine(n1);

    //==============================
    //           演算
    //==============================
    // + - * / %
    var x = 10; // int
    Console.WriteLine(x / 3); // 3
    Console.WriteLine(x % 3); // 1
    Console.WriteLine(x / 3.0); // 3.333....
    Console.WriteLine(x / (double)3); // 3.333....

    // ++ --
    var y = 5;
    y++;
    Console.WriteLine(y); // 6
    y--;
    Console.WriteLine(y); // 5

    var z = 6;
    // z = z + 10;
    z += 10;

    // AND OR NOT
    // && || !
    var flag = true;
    Console.WriteLine(!flag);

    //==============================
    //          文字列
    //==============================
    Console.WriteLine("hello " + "world");

    // \n, \t    改行、タブ
    Console.WriteLine("hell\no wo\trld");

    var name1 = "taguchi";
    var score1 = 52.3;

    Console.WriteLine(string.Format("{0} [{1}]", name1, score1)); // taguchi [52.3]

    Console.WriteLine($"{name1} [{score1}]");//C# 6以降
    Console.WriteLine($"{name1, -10} [{score1, 10}]");
    Console.WriteLine($"{name1, -10} [{score1, 10:0.00}]");
    Console.WriteLine($"{name1, -10} [{score1 + 25, 10:0.00}]");

    //==============================
    //          if
    //==============================
    // var score2 = int.Parse(Console.ReadLine());
    var score2 = int.Parse("90");

    // > >= < <= == !=
    if (score2 > 80) {
      Console.WriteLine("Great!");
    } else if (score2 > 60) {
      Console.WriteLine("Good!");
    } else {
      Console.WriteLine("so so ...!");
    }

    Console.WriteLine((score2 > 80) ? "Great" : "so so ...");

    //==============================
    //         switch
    //==============================
    // var signal = Console.ReadLine();
    var signal = "red";

    switch(signal) {
      case "red":
        Console.WriteLine("Stop!");
        break;
      case "blue":
      case "green":
        Console.WriteLine("Go!");
        break;
      case "yellow":
        Console.WriteLine("Caution!");
        break;
      default:
        Console.WriteLine("wrong signal!");
        break;
    }

    //==============================
    //         while
    //==============================
    // var i2 = 0;
    var i2 = 100;

    while (i2 < 10) {
      Console.WriteLine($"loop:{i2}");
      i2++;
    }

    do {
      Console.WriteLine($"loop2:{i2}");
      i2++;
    } while (i2 < 10);

    //==============================
    //         for
    //==============================
    // continue それ以降の処理を中止して次のループへ
    // break ループ自体を抜ける

    for (int i = 0; i < 10; i++) {
      if (i == 3) {
        continue;
      }
      if (i == 5) {
        break;
      }
      Console.WriteLine(i);
    }

    //==============================
    //         配列
    //==============================
    // 配列
    int[] scoresA1 = new int[3];
    scoresA1[0] = 10;
    scoresA1[1] = 30;
    scoresA1[2] = 20;
    int[] scoresA2 = new int[] {10, 30, 20};
    int[] scoresA3 = {10, 30, 20};
    var scoresA4 = new[] {10, 30, 20};

    scoresA4[1] = 40;
    Console.WriteLine(scoresA4[1]);
    Console.WriteLine(scoresA2);
    Console.WriteLine(scoresA3);

    //==============================
    //         foreach
    //==============================
    var scoresB1 = new[] {10, 30, 20};

    // for (int i = 0; i < scores.Length; i++) {
    //   Console.WriteLine(scores[i]);
    // }

    foreach (int score in scoresB1) {
      Console.WriteLine(score);
    }

    //==============================
    //         メソッド
    //==============================
    SayHi1();
    Console.WriteLine(SayHi2());
    Console.WriteLine(SayHi3());
    SayHi4("Tom", 30); // tom 30
    SayHi4("Bob"); // bob 23
    SayHi4(age: 26, name: "Steve"); // steve 26

    //==============================
    //         クラス
    //==============================
    User user = new User(); // インスタンス
    Console.WriteLine(user.name); // me
    user.SayHi(); // hi! me
    user.name = "taguchi";
    user.SayHi(); // hi! taguchi

    User tom = new User("Tom");
    tom.SayHi();
    User user2 = new User();
    user2.SayHi();

    AdminUser bob = new AdminUser("Bob");
    bob.SayHi();
    bob.SayHello();

    //==============================
    //         プロパティ
    //==============================
    Staff staff = new Staff();
    Console.WriteLine(staff.Name);
    staff.Name = "taguchi";
    Console.WriteLine(staff.Name);
    staff.Post = "Chief ";
    Console.WriteLine(staff.Post);

    //==============================
    //         インデクサ
    //==============================
    Team giants = new Team();
    giants[0] = "taguchi";
    giants[1] = "fkoji";
    giants[2] = "dotinstall";
    Console.WriteLine(giants[1]);    

    User.GetCount(); // 0
    User userA1 = new User();
    User userA2 = new User();
    User userA3 = new User();
    User.GetCount(); // 3

    Console.WriteLine(userA1);    
    Console.WriteLine(userA2);    
    Console.WriteLine(userA3);    

    //==============================
    //        抽象クラス
    //==============================
    Japanese aki = new Japanese();
    aki.SayHi();
    American mike = new American();
    mike.SayHi();

    //==============================
    //        インターフェース
    //==============================
    Partner partner = new Partner();
    partner.Share();

    //==============================
    //        ジェネリック
    //==============================
    MyData<string> s1 = new MyData<string>();
    s1.GetThree("hello");
    MyData<double> g1 = new MyData<double>();
    g1.GetThree(23.3);

    MyInteger mi = new MyInteger();
    mi.GetThree(55);

    //==============================
    //        名前空間
    //==============================
    DotinstallNamespace.Player player1 = new DotinstallNamespace.Player();
    Player player2 = new Player(); //using宣言しておけば、namespace省略可。
    player1.SayHi();
    player2.SayHi();

    //==============================
    //         構造体
    //==============================
    Point p1 = new Point(5, 3);
    Point p2 = new Point(12, 4);
    p1.GetInfo();
    p2.GetInfo();

    //==============================
    //         列挙型
    //==============================
    Direction dir = Direction.Right;
    Console.WriteLine((int)Direction.Right);

    switch (dir) {
      case Direction.Stay:
        // そのまま
        break;
      case Direction.Right:
        // 右へ
        break;
      case Direction.Left:
        // 左へ
        break;
    }

    //==============================
    //          例外
    //==============================
    MyExceptionPractice.Div(10, 0);
    MyExceptionPractice.Div(10, -3);

    //==============================
    //          デリゲート
    //==============================
    MyDelegate ShowMessage;

    ShowMessage = SayHiFromDeligater; // デリゲートにメソッドを登録
    ShowMessage += SayHelloFromDeligater; //メソッドを追加（マルチキャストデリゲート）
    ShowMessage -= SayHelloFromDeligater; //登録の解除

    ShowMessage(); // 実行

    //==============================
    //         匿名メソッド
    //==============================
    MyDelegate ShowMessage2;
    ShowMessage2 = delegate {
      Console.WriteLine("hi!(Anonymous methods)");
    };

    ShowMessage2();

    //==============================
    //         ラムダ式
    //==============================
    MyDelegate ShowMessage3;
    // ラムダ式: 引数 => 処理
    ShowMessage3 = () => {
      Console.WriteLine("hi!(Lambda expression)");
    };
    ShowMessage3 += () => Console.WriteLine("hello!(Lambda expression)");

    ShowMessage3();

    //==============================
    //         イベント
    //==============================
    MyButton btn = new MyButton();
    // メソッドを登録できる（以下ではラムダ式を使用している）
    btn.MyEvent += () => Console.WriteLine("Button Clicked!"); 
    btn.OnClicked();

    //==============================
    // Collection
    // - List（データの集合）
    // - HashSet（順番を持たない、かつ重複を許さないデータの集合。順番を指定してアクセスする事はできない。）
    // - Dictionary（キーと値でデータを管理していくデータの集合）
    //※要using System.Collections.Generic;
    //==============================

    //------------
    //    List  
    //------------
    List<int> scoresA = new List<int>();
    scoresA.Add(30);
    scoresA.Add(80);
    scoresA.Add(60);

    List<int> scoresB = new List<int>() { 30, 80 , 60 };
    scoresB[1] = 100;
    Console.WriteLine(scoresB.Count);
    foreach (var score in scoresB) {
      Console.WriteLine(score);
    }

    //------------
    //  HashSet  
    //------------
    HashSet<int> answers = new HashSet<int>() { 3, 5, 8, 5 }; //重複分は無視される
    answers.Add(10); // 3, 5, 8, 10
    answers.Remove(3); // 5, 8, 10
    Console.WriteLine(answers.Contains(3)); // false
    foreach (var answer in answers) {
      Console.WriteLine(answer);
    }

    //------------
    // Dictionary  
    //------------
    Dictionary<string, int> registrants = new Dictionary<string, int>() {
      {"taguchi", 50},
      {"fkoji", 80},
    };
    registrants.Add("dotinstall", 40);
    Console.WriteLine(registrants["fkoji"]); // 80
    registrants["taguchi"] = 60;
    foreach (KeyValuePair<string, int> registrant in registrants) {
      Console.WriteLine($"{registrant.Key}: {registrant.Value}");
    }

    //==============================
    //         LINQ
    //==============================
    //要 using System.Linq;
    List<double> prices = new List<double>() { 53.2, 48.2, 32.8 };

    //------------
    //    SQL
    //------------
    var resultsA = from price in prices
      where price * 1.08 > 50.0
      select price * 1.08;    

    foreach (var result in resultsA) {
      Console.WriteLine(result);
    }

    //------------
    //   Method 
    //------------
    var results = prices
      .Select(n => n * 1.08)
      .Where(n => n > 50.0);

    foreach (var result in results) {
      Console.WriteLine(result);
    }

    //-----< Sample01 >-----
    List<Customer> _customers = new List<Customer>();
    _customers.Add(new Customer{ Name = "Fukuzawa", Age = 35, IsMarried = true,  });
    _customers.Add(new Customer{ Name = "Higuchi" , Age = 28, IsMarried = true,  });
    _customers.Add(new Customer{ Name = "Noda"    , Age = 42, IsMarried = false, });
    _customers.Add(new Customer{ Name = "Igawa"   , Age = 21, IsMarried = false, });
    _customers.Add(new Customer{ Name = "Sawada"  , Age = 31, IsMarried = true,  });
    Console.WriteLine("====================");

    // All
    foreach (var customer in _customers)
    {
        Console.WriteLine(customer.Name);
    }
    Console.WriteLine("====================");

    // フィルタリング１
    foreach (var customer in _customers.Where(n => n.IsMarried))
    {
        Console.WriteLine(customer.Name);
    }
    Console.WriteLine("====================");

    // フィルタリング２
    foreach (var customer in _customers
                                .Where(n => n.IsMarried)
                                .Where(n => n.Age > 30)
                                )
    {
        Console.WriteLine(customer.Name);
    }
    Console.WriteLine("====================");
  }
}
