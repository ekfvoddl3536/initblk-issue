```

BenchmarkDotNet v0.13.9+228a464e8be6c580ad9408e98f18813f6407fb5a, Windows 11 (10.0.22621.2428/22H2/2022Update/SunValley2) (Hyper-V)
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.402
  [Host]   : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2
  .NET 7.0 : .NET 7.0.12 (7.0.1223.47720), X64 RyuJIT AVX2

Job=.NET 7.0  Runtime=.NET 7.0  

```
| Method  | Bytes      | Mean               | Error           | StdDev          | Min                | Max                | Ratio |
|-------- |----------- |-------------------:|----------------:|----------------:|-------------------:|-------------------:|------:|
| **Initblk** | **256**        |           **4.553 ns** |       **0.0059 ns** |       **0.0056 ns** |           **4.546 ns** |           **4.565 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **512**        |           **4.624 ns** |       **0.0019 ns** |       **0.0018 ns** |           **4.621 ns** |           **4.627 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **1024**       |           **6.179 ns** |       **0.0186 ns** |       **0.0156 ns** |           **6.153 ns** |           **6.209 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **2048**       |           **9.902 ns** |       **0.0055 ns** |       **0.0049 ns** |           **9.894 ns** |           **9.912 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **4096**       |          **19.886 ns** |       **0.0085 ns** |       **0.0080 ns** |          **19.870 ns** |          **19.902 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **8192**       |          **39.050 ns** |       **0.0331 ns** |       **0.0310 ns** |          **39.005 ns** |          **39.113 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **16384**      |          **74.185 ns** |       **0.4286 ns** |       **0.4009 ns** |          **73.735 ns** |          **74.873 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **32768**      |         **148.440 ns** |       **0.3875 ns** |       **0.3435 ns** |         **147.942 ns** |         **149.248 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **65536**      |         **972.276 ns** |       **0.3815 ns** |       **0.3382 ns** |         **971.681 ns** |         **972.891 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **131072**     |       **1,937.387 ns** |       **1.9977 ns** |       **1.8686 ns** |       **1,935.112 ns** |       **1,941.891 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **262144**     |       **3,856.609 ns** |       **2.1661 ns** |       **1.8088 ns** |       **3,854.787 ns** |       **3,859.490 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **524288**     |       **7,684.253 ns** |       **3.5314 ns** |       **3.3033 ns** |       **7,679.086 ns** |       **7,691.449 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **1048576**    |      **15,371.964 ns** |      **16.6699 ns** |      **15.5931 ns** |      **15,351.144 ns** |      **15,395.074 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **2097152**    |      **72,677.835 ns** |      **53.8924 ns** |      **45.0026 ns** |      **72,599.487 ns** |      **72,759.082 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **4194304**    |     **147,166.070 ns** |     **454.4317 ns** |     **379.4711 ns** |     **146,105.273 ns** |     **147,600.732 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **8388608**    |     **294,394.017 ns** |     **783.2031 ns** |     **732.6087 ns** |     **293,023.340 ns** |     **295,223.682 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **16777216**   |     **589,575.807 ns** |     **885.9262 ns** |     **828.6959 ns** |     **587,409.473 ns** |     **590,351.660 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **33554432**   |   **1,227,372.356 ns** |  **12,009.6585 ns** |  **10,028.6087 ns** |   **1,214,819.727 ns** |   **1,248,880.273 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **67108864**   |   **3,860,100.732 ns** |  **67,697.6619 ns** |  **88,026.0826 ns** |   **3,690,404.297 ns** |   **4,008,267.188 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **134217728**  |   **9,861,646.979 ns** | **143,218.0171 ns** | **133,966.2221 ns** |   **9,723,589.062 ns** |  **10,178,220.312 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **268435456**  |  **20,247,511.875 ns** | **114,250.5162 ns** | **106,870.0038 ns** |  **20,079,390.625 ns** |  **20,424,534.375 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **536870912**  |  **40,850,480.000 ns** | **235,609.2077 ns** | **220,388.9991 ns** |  **40,556,184.615 ns** |  **41,360,661.538 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **1073741824** |  **82,644,324.762 ns** | **326,680.8373 ns** | **305,577.4579 ns** |  **82,334,285.714 ns** |  **83,439,500.000 ns** |  **1.00** |
|         |            |                    |                 |                 |                    |                    |       |
| **Initblk** | **2147483648** | **166,624,584.444 ns** | **522,220.8043 ns** | **488,485.6643 ns** | **165,439,866.667 ns** | **167,415,000.000 ns** |  **1.00** |