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
enum Signal
{
    Red = 0,
    Yellow = 1,
    Blue = 2
}
Dictionary<int, string> _signalDict = new Dictionary<int, string>() {
    {0, "赤"},
    {1, "黄色"},
    {2, "青" + Environment.NewLine + "と緑"},
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
