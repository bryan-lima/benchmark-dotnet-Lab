using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using SimpleBenchmarks;

Console.WriteLine("\n\nStarting benchmarks...");

Summary _summary = BenchmarkRunner.Run<FirstBenchmark>();

Console.WriteLine("\n\nBenchmarks completed!");
