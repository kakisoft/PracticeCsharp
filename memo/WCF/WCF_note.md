## チュートリアル
https://docs.microsoft.com/ja-jp/dotnet/framework/wcf/getting-started-tutorial    
https://docs.microsoft.com/ja-jp/dotnet/framework/wcf/basic-wcf-programming    

## WCF クライアントの概要
https://docs.microsoft.com/ja-jp/dotnet/framework/wcf/wcf-client-overview    

## WCF(Windows Communication Foundation)
.NET Framework 3.0～　の通信サブシステム。    
アプリケーション同士をネットワーク経由で接続する仕組み。


## WCF の三要素（ABC）

 * A：Address（どこへ？）      URLなど
 * B：Binding（どのように？）  通信プロトコル、セキュリティ機構の種類
 * C：Contract（なにを？）     

このABCを合わせて、エンドポイントと呼ぶ。


## WebChannelFactory<TChannel> クラス
クライアント上の Windows Communication Foundation (WCF) Web サービスにアクセスするためのクラス。    
https://msdn.microsoft.com/ja-jp/library/bb908674(v=vs.110).aspx


## WSHttpBinding Class
https://docs.microsoft.com/ja-jp/dotnet/api/system.servicemodel.wshttpbinding?view=netframework-4.7.1

## バインディング
WCFサービスのエンドポイントへの接続に必要な通信の詳細設定を指定する際に使用するオブジェクトのことです。 
WCF サービスの各エンドポイントでは、バインディングを適切に指定する必要があります。 

## エンドポイント
メッセージを送信または受信 (または送受信) する場所となる構造体。       
エンドポイントには、どこにメッセージを送信できるかを明確に示す場所 (アドレス)、      
メッセージの送信方法を記載した通信機構の仕様 (バインディング)、      
およびその場所で送信または受信 (または送受信) 可能な一連のメッセージの内容を示す定義 (サービス コントラクト) が含まれます。


