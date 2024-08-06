using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using SimpleBenchmarks;
using SimpleBenchmarks.Benchmarks;

Console.WriteLine("\n\nStarting benchmarks...");

BenchmarkRunner.Run<FirstBenchmark>();

Console.WriteLine("\n\nBenchmarks completed!");
