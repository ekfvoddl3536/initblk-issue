using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace Net481
{
    [SimpleJob(RuntimeMoniker.Net481, baseline: true)]
    [MarkdownExporter]
    [MinColumn, MaxColumn]
    public class Program
    {
        public const long NUMBER_OF_BYTES = 0x8000_0000; // 2GiB
        public const long SIZE = 128;

        [Params(
            SIZE << 1,
            SIZE << 2,
            SIZE << 3,
            SIZE << 4,
            SIZE << 5,
            SIZE << 6,
            SIZE << 7,
            SIZE << 8,
            SIZE << 9,
            SIZE << 10,
            SIZE << 11,
            SIZE << 12,
            SIZE << 13,
            SIZE << 14,
            SIZE << 15,
            SIZE << 16,
            SIZE << 17,
            SIZE << 18,
            SIZE << 19,
            SIZE << 20,
            SIZE << 21,
            SIZE << 22,
            SIZE << 23,
            SIZE << 24)]
        public static long Bytes;

        private static IntPtr Array;

        [GlobalSetup]
        public void Setup() => Array = Marshal.AllocHGlobal(new IntPtr(Bytes));

        [GlobalCleanup]
        public void Cleanup() => Marshal.FreeHGlobal(Array);

        [Benchmark]
        public unsafe void Initblk() => Unsafe.InitBlock((byte*)Array, 0, (uint)Bytes);

        public static void Main() => BenchmarkRunner.Run<Program>();
    }
}