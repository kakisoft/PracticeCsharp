using System;

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

  /*
    comment
  */
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
    var m = 5; // int
    var n = "world"; // string

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

    Console.WriteLine($"{name1} [{score1}]");
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
  }
}