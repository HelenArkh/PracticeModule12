``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1316 (1909/November2018Update/19H2)
Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|           Method |         Mean |       Error |      StdDev |
|----------------- |-------------:|------------:|------------:|
|        UseString | 113,870.6 μs | 1,582.20 μs | 1,402.58 μs |
| UseStringBuilder |     497.9 μs |     4.03 μs |     3.57 μs |
