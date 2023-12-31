```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 10 (10.0.19044.3570/21H2/November2021Update) (Hyper-V)
Intel Xeon Platinum 8168 CPU 2.70GHz, 1 CPU, 4 logical and 2 physical cores
  [Host]               : .NET Framework 4.8.1 (4.8.9195.0), X64 RyuJIT VectorSize=256
  .NET Framework 4.8.1 : .NET Framework 4.8.1 (4.8.9195.0), X64 RyuJIT VectorSize=256

Job=.NET Framework 4.8.1  Runtime=.NET Framework 4.8.1  

```
| Method  | Bytes      | Mean               | Error             | StdDev            | Min                | Max               | Ratio |
|-------- |----------- |-------------------:|------------------:|------------------:|-------------------:|------------------:|------:|
| **Initblk** | **256**        |           **9.217 ns** |         **0.2031 ns** |         **0.3556 ns** |           **8.607 ns** |          **10.25 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **512**        |          **18.749 ns** |         **0.4022 ns** |         **0.5370 ns** |          **17.999 ns** |          **19.96 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **1024**       |          **38.001 ns** |         **0.7690 ns** |         **0.8856 ns** |          **36.554 ns** |          **39.32 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **2048**       |          **78.172 ns** |         **1.5232 ns** |         **1.9264 ns** |          **75.250 ns** |          **82.12 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **4096**       |         **155.228 ns** |         **2.4125 ns** |         **2.1386 ns** |         **152.304 ns** |         **158.79 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **8192**       |         **315.404 ns** |         **5.2986 ns** |         **4.9563 ns** |         **306.635 ns** |         **322.02 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **16384**      |         **631.685 ns** |        **12.1901 ns** |        **14.0381 ns** |         **607.404 ns** |         **663.71 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **32768**      |       **1,343.110 ns** |        **26.0422 ns** |        **27.8649 ns** |       **1,291.385 ns** |       **1,385.69 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **65536**      |       **2,791.507 ns** |        **43.2816 ns** |        **40.4856 ns** |       **2,733.588 ns** |       **2,890.36 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **131072**     |       **5,676.695 ns** |       **113.1143 ns** |       **134.6546 ns** |       **5,505.207 ns** |       **5,970.90 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **262144**     |      **11,230.862 ns** |       **201.1269 ns** |       **247.0019 ns** |      **10,960.587 ns** |      **11,863.57 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **524288**     |      **76,037.799 ns** |       **791.7447 ns** |       **701.8611 ns** |      **74,931.842 ns** |      **77,567.45 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **1048576**    |     **152,627.303 ns** |     **2,134.4629 ns** |     **1,996.5779 ns** |     **149,497.681 ns** |     **155,320.92 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **2097152**    |     **304,451.493 ns** |     **3,560.0146 ns** |     **3,330.0399 ns** |     **298,226.050 ns** |     **309,240.60 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **4194304**    |     **604,423.912 ns** |     **8,247.8674 ns** |     **7,311.5196 ns** |     **595,590.820 ns** |     **617,517.19 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **8388608**    |   **1,242,036.315 ns** |    **23,484.8047 ns** |    **21,967.7008 ns** |   **1,208,872.852 ns** |   **1,289,357.81 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **16777216**   |   **2,479,600.247 ns** |    **30,403.6339 ns** |    **28,439.5780 ns** |   **2,443,259.961 ns** |   **2,530,226.76 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **33554432**   |   **4,953,065.084 ns** |    **63,340.8682 ns** |    **52,892.4936 ns** |   **4,851,553.125 ns** |   **5,017,734.38 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **67108864**   |  **10,011,653.229 ns** |   **158,044.7279 ns** |   **147,835.1365 ns** |   **9,778,248.438 ns** |  **10,267,171.88 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **134217728**  |  **20,606,144.167 ns** |   **397,914.8635 ns** |   **372,209.8102 ns** |  **19,922,409.375 ns** |  **21,207,987.50 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **268435456**  |  **41,440,615.556 ns** |   **605,216.9405 ns** |   **566,120.3016 ns** |  **40,586,133.333 ns** |  **42,524,958.33 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **536870912**  |  **86,622,164.286 ns** | **1,704,442.3533 ns** | **1,510,943.7507 ns** |  **84,588,866.667 ns** |  **89,417,383.33 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **1073741824** | **173,709,377.778 ns** | **1,996,267.4577 ns** | **1,867,309.8185 ns** | **171,109,500.000 ns** | **177,293,866.67 ns** |  **1.00** |
|         |            |                    |                   |                   |                    |                   |       |
| **Initblk** | **2147483648** | **351,844,900.000 ns** | **5,966,033.3308 ns** | **5,580,631.2792 ns** | **344,609,600.000 ns** | **362,707,900.00 ns** |  **1.00** |
