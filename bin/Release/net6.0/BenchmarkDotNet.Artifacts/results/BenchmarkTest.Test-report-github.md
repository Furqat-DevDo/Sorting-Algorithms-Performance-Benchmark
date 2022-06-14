``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i5-10300H CPU 2.50GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|               Method |       Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|--------------------- |-----------:|---------:|---------:|-----:|-------:|----------:|
|    TestingBubbleSort | 3,364.2 ns | 13.61 ns | 12.73 ns |    5 | 0.0305 |     136 B |
|      TestingHeapSort |   208.1 ns |  0.78 ns |  0.70 ns |    3 | 0.0324 |     136 B |
| TestingInsertionSort |   262.4 ns |  2.37 ns |  1.98 ns |    4 | 0.0324 |     136 B |
| TestingSelectionSort |   188.3 ns |  1.14 ns |  1.07 ns |    2 | 0.0324 |     136 B |
|     TestingQuickSort |   135.0 ns |  1.74 ns |  1.62 ns |    1 | 0.0324 |     136 B |
