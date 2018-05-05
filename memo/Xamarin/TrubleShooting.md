##  エラー	CS0103	現在のコンテキストに 'InitializeComponent' という名前は存在しません。
プロジェクトを新規作成した時にも発生する。
```
ソリューションのPCLをアンロード→リビルド→VSを閉じる→PCL読み込み→リビルド
```


## This project references NuGet package(s) that are missing on this computer. 
ソース管理や別のダウンロードからプロジェクトのソース コードを取得する場合によく発生します。    
https://docs.microsoft.com/ja-jp/nuget/Consume-Packages/Package-restore-troubleshooting    


