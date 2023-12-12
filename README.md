# dotnet_wasmtime_example1

## 概要

* wasmtime-dotnet の README.md に記載のサンプルをやってみる
* [nodejs_wasm_example1](https://github.com/Tobotobo/nodejs_wasm_example1/tree/main) の test.wasm を今度は dotnet で実行してみる

wasmtime-dotnet  
https://github.com/bytecodealliance/wasmtime-dotnet

## 詳細

```
dotnet new gitignore
```

### サンプル

構築
```
dotnet new console -o WasmIntro
dotnet add ./WasmIntro package wasmtime
```

実行
```
dotnet run --project ./WasmIntro
```

実行結果
```
> dotnet run --project ./WasmIntro 
Hello from C#!
```

### test.wasm を実行

構築
```
dotnet new console -o WasmIntro2
dotnet add ./WasmIntro2 package wasmtime
```

実行
```
dotnet run --project ./WasmIntro2
```

実行結果
```
> dotnet run --project ./WasmIntro2
7 + 4 = 11
```

## 環境
```
> dotnet --info
.NET SDK:
 Version:           8.0.100   
 Commit:            57efcf1350
 Workload version:  8.0.100-manifests.71b9f198

ランタイム環境:
 OS Name:     Windows
 OS Version:  10.0.19045
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\8.0.100\

インストール済みの .NET ワークロード:
 Workload version: 8.0.100-manifests.71b9f198
```
