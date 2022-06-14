``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-10300H CPU 2.50GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|               Method |       Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|--------------------- |-----------:|---------:|---------:|-----:|-------:|----------:|
|    TestingBubbleSort | 3,967.3 ns | 55.78 ns | 49.45 ns |    6 | 0.0305 |     136 B |
|      TestingHeapSort |   247.4 ns |  1.93 ns |  1.81 ns |    3 | 0.0324 |     136 B |
| TestingInsertionSort |   319.8 ns |  6.30 ns |  5.89 ns |    4 | 0.0324 |     136 B |
| TestingSelectionSort |   223.3 ns |  1.83 ns |  1.71 ns |    2 | 0.0324 |     136 B |
|     TestingQuickSort |   143.7 ns |  2.29 ns |  2.15 ns |    1 | 0.0324 |     136 B |
|     TestingRadixSort | 1,377.3 ns | 16.23 ns | 15.18 ns |    5 | 0.0591 |     248 B |
