using System;
  /*
    comment
  */
class MyApp {

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
    int i = 100;

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

    // \n, \t
    Console.WriteLine("hell\no wo\trld");

    var name = "taguchi";
    var score = 52.3;

    Console.WriteLine(string.Format("{0} [{1}]", name, score)); // taguchi [52.3]

    Console.WriteLine($"{name} [{score}]");
    Console.WriteLine($"{name, -10} [{score, 10}]");
    Console.WriteLine($"{name, -10} [{score, 10:0.00}]");
    Console.WriteLine($"{name, -10} [{score + 25, 10:0.00}]");
  }
}