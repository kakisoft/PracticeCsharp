/*
参考サイト：Doxygen様
http://www.takeash.net/wiki/?Doxygen

１つ１つのタグの使い方の説明はあっても、「で、実際にどう書くの？」となった時に、参考になるサイトがほとんどなかったので、
実例込みで書いてくれるサイトは超助かりました。
*/
 using System;
 
 /**
  * @mainpage C#の継承のテスト
  * <p>ネタ元<br>
  * http://ufcpp.net/study/csharp/oo_inherit.html </p>
  */
 
 /// <summary>
 /// C#の継承のテスト用プログラム
 /// </summary>
 namespace TestInherit
 {
     /// <summary>
     /// 人間
     /// </summary>
     /// <remarks>
     /// 名前と年齢の２つの情報を持っています。
     /// </remarks>
     class Person
     {
         /// <summary>
         /// 名前
         /// </summary>
         public string Name { get; set; }
         /// <summary>
         /// 年齢
         /// </summary>
         public int Age { get; set; }
 
         /// <summary>
         /// コンストラクタ
         /// </summary>
         /// <param name="name">名前</param>
         /// <param name="age">年齢</param>
         public Person(string name, int age)
         {
             Name = name;
             Age = age;
         }
 
         /// <summary>
         /// 文字列化
         /// </summary>
         /// <returns>名前と年齢を表す文字列</returns>
         public new string ToString()
         {
             return "Name: " + Name + "\n" + "Age: " + Age + "\n";
         }
     }
 
     /// <summary>
     /// 学生
     /// </summary>
     /// <remarks>
     /// 人間の情報に加えて学籍番号の情報を持っています。
     /// </remarks>
     class Student : Person
     {
         /// <summary>
         /// 学籍番号
         /// </summary>
         public int Id { get; set; }
 
         /// <summary>
         /// コンストラクタ
         /// </summary>
         /// <param name="name">名前</param>
         /// <param name="age">年齢</param>
         /// <param name="id">学籍番号</param>
         public Student(string name, int age, int id) : base(name, age)
         {
             Id = id;
         }
 
         /// <summary>
         /// 文字列化
         /// </summary>
         /// <returns>名前と年齢と学籍番号を表す文字列</returns>
         public new string ToString()
         {
             return base.ToString() + "ID: " + Id + "\n";
         }
 
         /// <summary>
         /// 動作テスト
         /// </summary>
         /// <param name="args">コマンドライン引数</param>
         static void Main(string[] args)
         {
             Student Tanaka = new Student("田中", 19, 1000);
             Console.WriteLine(Tanaka.ToString());
         }
     }
 }
 
