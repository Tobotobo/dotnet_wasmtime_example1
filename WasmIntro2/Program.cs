using System;
using Wasmtime;

using var engine = new Engine();

using var module = Module.FromFile(engine, "test.wasm");

using var linker = new Linker(engine);
using var store = new Store(engine);

// linker.Define(
//     "",
//     "hello",
//     Function.FromCallback(store, () => Console.WriteLine("Hello from C#!"))
// );



var instance = linker.Instantiate(store, module);
// var run = instance.GetAction("run")!;
// run();

var addTwo = instance.GetFunction<Int32, Int32, Int32>("addTwo")!;
var answer = addTwo(7, 4);
Console.WriteLine($"7 + 4 = {answer}");