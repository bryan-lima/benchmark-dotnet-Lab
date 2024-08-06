using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using SimpleBenchmarks;

Console.WriteLine("\n\nStarting benchmarks...");

BenchmarkRunner.Run<FirstBenchmark>();

Console.WriteLine("\n\nBenchmarks completed!");
