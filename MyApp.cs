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
    bool flag = true;

    // 型推論
    var x = 5; // int
    var y = "world"; // string

  }
}