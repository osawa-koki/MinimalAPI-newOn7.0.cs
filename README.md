# MinimalAPI-newOn7.0.cs

.NET7.0で新たに追加されたMinimalAPIに関する機能を試してみよう♪

## 実行方法

```shell
# Dockerfileからビルドして
docker build ./ -t dotnet7

# 作成されたコンテナを実行
docker run -it dotnet7

# ディレクトリを移動して
cd MinimalAPI-newOn7.0.cs

# .NETプロジェクトをデバグ実行
dotnet run
```

## エラー未解決です、、、

なぜか、最初の実行は成功して、二回目以降はエラーとなる、、、  
ログも出力されないから原因追及ができないけど、おそらく.NETのバージョンとプロジェクトのバージョンの不整合が問題???  
それならビルドが成功することがあるのがうまく説明できないが、、、  
