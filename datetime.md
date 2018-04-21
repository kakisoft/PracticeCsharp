```cs
// 20180621 → "２０１８年６月１日 (金)"
int date1 = 20180601;
string date2 = date1.ToString();
string date3 = date2.Substring(0, 4) + "/" + date2.Substring(4, 2) + "/" + date2.Substring(6, 2);
DateTime date4 = DateTime.Parse(date3);
string date5 = date4.ToString("yyyy年M月d日 (ddd)");
string date6 = Regex.Replace(date5, "[0-9]", p => ((char)(p.Value[0] - '0' + '０')).ToString());
Console.WriteLine(date6);

// 930 → "９：３０"
int time1 = 930;
string time2 = time1.ToString().PadLeft(4, '0');
string time3 = time2.Substring(0, 2) + ":" + time2.Substring(2, 2);
DateTime time4 = DateTime.Parse(DateTime.Now.ToString("yyyy/MM/dd " + time3));
string time5 = time4.ToString("H：m");
string time6 = Regex.Replace(time5, "[0-9]", p => ((char)(p.Value[0] - '0' + '０')).ToString());
```


|  記号  |      意味          |  表示例(ja-JP) |  表示例(en-US) |
|:-------|:-------------------|:---------------|:---------------|
|  yy    |  年2桁             |  15            |  15            |
|  yyyy  |  年4桁             |  2015          |  2015          |
|  M     |  月（ゼロ埋なし）  |  3             |  3             |
|  MM    |  月（ゼロ埋あり）  |  03            |  03            |
|  MMM   |  月の省略名称      |  3             |  Mar           |
|  MMMM  |  月の名称          |  3月           |  March         |
|  d     |  日（ゼロ埋なし）  |  5             |  5             |
|  dd    |  日（ゼロ埋あり）  |  05            |  05            |
|  ddd   |  曜日の省略名称    |  火            |  Tue           |
|  dddd  |  曜日の名称        |  火曜日        |  Tuesday       |
|  tt    |  午前/午後         |  午前          |  AM            |
|  h     |  時（ゼロ埋なし）  |  3             |  3             |
|  hh    |  時（01～12）      |  03            |  03            |
|  H     |  時（0～23）       |  15            |  15            |
|  HH    |  時（00～23）      |  15            |  15            |
|  m     |  分（0～59）       |  3             |  3             |
|  mm    |  分（00～59）      |  03            |  03            |
|  s     |  秒（0～59）       |  3             |  3             |
|  ss    |  秒（00～59）      |  03            |  03            |
|  f     |  1/10秒            |  1             |  1             |
|  ff    |  1/100秒           |  01            |  01            |
|  fff   |  1/1000秒          |  012           |  012           |


