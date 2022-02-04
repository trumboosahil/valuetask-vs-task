``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT


```
|                   Method |          Mean |        Error |       StdDev |        Median | Allocated |
|------------------------- |--------------:|-------------:|-------------:|--------------:|----------:|
|      RunTaskWithOutCache | 285,241.20 μs | 4,760.612 μs | 3,975.327 μs | 285,950.60 μs | 403,384 B |
| RunValueTaskWithOutCache | 293,853.58 μs | 5,604.150 μs | 4,679.719 μs | 294,591.70 μs | 399,752 B |
|         RuntaskWithCache |      34.01 μs |     0.544 μs |     1.098 μs |      33.50 μs |   7,536 B |
|    RunValuetaskWithCache |      29.80 μs |     0.590 μs |     1.257 μs |      29.20 μs |     336 B |
