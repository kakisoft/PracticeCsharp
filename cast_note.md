```cs
//文字列をint型に変換
int i = int.Parse("100");

//文字列をlong型に変換
long l = long.Parse("100");

//文字列をfloat型に変換
float f = float.Parse("100.1");

//文字列をdouble型に変換
double d = double.Parse("100.1");

//文字列をbool型に変換
bool b = bool.Parse("True");

//数値を文字列に変換
int x = 256;
string  s = x.ToString();
```

## 参照→プリミティブ（nullの可能性がある場合）
```cs
int intSeriesNo = seatContent.SeriesNo;
int.TryParse(item.SeriesNo, out intSeriesNo);
```

## note
```cs
  int ticketOfNumber;
  if (int.TryParse(numberOfTicketsCluster.DispText, out ticketOfNumber) == false)
  {
      numberOfTicketsCluster.DispText = "0";
      return;
  }

  ticketOfNumber += addNumber;
  if (ticketOfNumber < 0)
  {
      ticketOfNumber = 0;
  }
```
