# DxLibTemplate

Visual Studio のプロジェクトテンプレートに、DX ライブラリを使った C++ プロジェクトが追加されます。

## 必要要件

Visual Studio 2017, 2019, 2022 のどれかがインストールされている環境

## プロジェクトテンプレートのインストール方法

[Visual C++ 用テンプレート](https://marketplace.visualstudio.com/items?itemName=KamenokoSoft.dxlib-template-for-win32)  または
[Visual C# 用テンプレート](https://marketplace.visualstudio.com/items?itemName=KamenokoSoft.dxlib-template-for-win32-csharp) に移動します。

![downloadext1.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/88513743-7433-4b34-424d-d17275e54afe.png)

遷移先のページ上の緑色の "Download" ボタンをクリックして、拡張機能をダウンロードします。

![downloadext2.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/1a1a9553-a12c-ab8e-2a25-bace7ed20d70.png)

ダウンロードが終わったら、ダウンロードした拡張機能をダブルクリックして、実行します。

![installext1.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/fa8a17f1-f381-8125-e506-c5ada106413a.png)

変更内容を確認するダイアログが出てくるので、"Install" をクリックします。

![installext2.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/3c5adddf-d59c-af4b-8399-52b2edf35980.png)

拡張機能のインストールが終わったら、"Close" ボタンをクリックして、ウィンドウを閉じます。

## プロジェクトの作成

お使いの Visual Studio を起動して、スタートウィンドウを表示します。

![launchvs1.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/d52c53ed-a448-ec09-9953-b2942f03c187.png)

スタートウィンドウが表示されたら、新しいプロジェクトの作成をクリックします。

検索欄に "DxLib" と入力し、出てきた "DxLib" プロジェクトテンプレートを選択して、右下の "OK" をクリックします。

![launchvs2.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/3e5632a0-e00f-cee2-9986-372de31033e1.png)

プロジェクト名の入力する画面では、好きな名前を入力して、右下の "OK" をクリックします。

![launchvs3.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/0f399e58-b5df-687a-6e2b-7acf64ee2774.png)

## プロジェクトのビルドと実行

ツールセットの更新画面が出てきたら、そのまま "OK" をクリックします。

![retarget.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/7070cd96-34b1-bba3-6a82-02e054a1c08f.png)

ソースファイルに赤波線が出ていても、そのまま Visual Studio 上部の "Windows ローカルデバッガ" をクリックして、ビルドを開始します。

![build1.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/e9a16432-13f7-44cc-0174-a1f6e45bcf95.png)

最初のビルドでは、依存関係にあるパッケージのダウンロードを行うため、5分以上時間がかかることがあります。気長に待ちましょう。

ビルドが終わり、DX ライブラリの黒い画面が出てきたら、成功です。

![build2.png](https://qiita-image-store.s3.ap-northeast-1.amazonaws.com/0/158514/dc4af7bb-8e96-81dd-add0-8bf27fa67a41.png)
