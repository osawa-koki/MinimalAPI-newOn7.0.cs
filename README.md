# MinimalAPI-newOn7.0.cs

.NET7.0で新たに追加された機能をテストするための学習目的プロジェクト。  

## 実行方法

```shell
# Dockerfileのビルドの実行
docker build -t new-at-dotnet7 .
docker run -p 80:80 -it --rm --name my-new-at-dotnet7 new-at-dotnet7

# 一行で書くなら
docker build -t new-at-dotnet7 . && docker run -p 80:80 -it --rm --name my-new-at-dotnet7 new-at-dotnet7
```

## 参考文献

- <https://learn.microsoft.com/ja-jp/aspnet/core/release-notes/aspnetcore-7.0?view=aspnetcore-7.0>
