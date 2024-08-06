using BenchmarkDotNet.Running;
using SimpleBenchmarks;
using SimpleBenchmarks.Benchmarks;

Console.WriteLine("\n\nStarting benchmarks...");

BenchmarkRunner.Run<FirstBenchmark>();
BenchmarkRunner.Run<StringSplitBenchmark>();

Console.WriteLine("\n\nBenchmarks completed!");
