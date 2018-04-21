//================
//   Lamda
//================
List<string> strlist = new List<string>() { "a", "b", "c" };
var result1 = strlist.Where(n => n == "c");

var result2 = strlist
                  .Where(n => n == "c")
                  .Select(n => "'" + n + "'");

//==========================
//   enum を foreachで回す
//==========================
#region Enum定義
/// <summary>
/// 条件
/// </summary>
enum Signal : int
{
    Red = 0,
    Yellow = 1,
    Blue = 2
}
Dictionary<int, string> _signalDict = new Dictionary<int, string>() {
    {(int)Signal.Red   , "赤"},
    {(int)Signal.Yellow, "黄色"},
    {(int)Signal.Blue  , "青" + Environment.NewLine + "と緑"},
};
#endregion

//-----< enum を foreachで回す >-----
foreach (int r in Enum.GetValues(typeof(Signal)))
{
    var t = new RadioButton();
    t.Name = "enumRadioButton_" + r;

    var b = new TextBlock();
    b.Text = _signalDict[r];
    b.TextWrapping = TextWrapping.Wrap;
    t.Content = b;

    t.Tag = r;
}

//=============================
//  リストの中身を値渡しでコピー
//=============================

//コンストラクタの第一引数に、コピー元を渡す。
myList01 = new List<someInfo>(myList02);


//=============================
//   enumをエレメントのタグにぶち込み、イベントの発生元として検知
//=============================
enum signalDict : int
{
    Red = 0,
    Blue = 1,
    Yello = 2
}

t.Click += (sender, e) => buttonA_Clicked(sender);

private void buttonA_Clicked(object sender)
{

    if ((signalDict)((CheckBox)sender).Tag == signalDict.Blue)
    {
        Console.WriteLine("aaaa");
    }
}


//==========================
//   遅延バインディング
//==========================
dynamic testobj;
testobj = DateTime.Now;
Console.WriteLine(testobj.Month + "月");



//==========================
//  デバッグ用ログインユーザ
//==========================
        public SystemUserLoginWindow()
        {
            InitializeComponent();
#if DEBUG
            this.textboxUserId.Text = "TestUser";
            this.textboxLoginId.Text = "1";
            this.passwordBoxLoginPassword.Password = "1";
#endif
        }
