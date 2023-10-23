## .NET `initblk` Performance Issue
This repository contains benchmark data and analysis for the initblk instruction's performance across different versions of .NET and varying microarchitectures.  

### Overview
It has been observed that the performance of the initblk instruction in the latest versions of .NET might not be as optimal as in the .NET Framework, especially when handling memory segments larger than 64MiB. This behavior seems to be more pronounced on newer microarchitectures, like Intel Sunny Cove and Golden Cove, compared to older ones like Skylake.  
  
### Dataset
**Microarchitectures**: 
- Intel Skylake
    - Intel(R) Xeon(R) Platinum 8168 CPU @ 2.70GHz (4 vCPU)
- Intel Sunny Cove
    - Intel(R) Xeon(R) Platinum 8370C CPU @ 2.80GHz (4 and 8 vCPU)
- Intel Golden Cove
    - 12th Gen Intel(R) Core(TM) i9-12900K, (E-cores **disabled**, using only 8 P-cores)
- Intel Golden Cove (P-Core) + Intel Gracemont (E-Core)
    - 12th Gen Intel(R) Core(TM) i9-12900K
    - 12th Gen Intel(R) Core(TM) i5-12600K
   
**.NET Versions**: 
- .NET Framework 4.8
    - .NET Framework 4.8.1
- .NET 7.0
  
**Memory Segments**: Data ranging from `128 bytes` up to `2.0GiB`  

### Observations
On the `Skylake` microarchitecture, the latest .NET version still outperforms .NET Framework.  
However, on newer microarchitectures like `Sunny Cove` and `Golden Cove`, .NET Framework seems to perform faster.  
   
### Disclaimer
The data in this repository is by no means exhaustive and is based on the benchmarks conducted in specific environments. Actual performance can vary based on various factors.  
