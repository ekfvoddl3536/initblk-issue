#if NETFRAMEWORK
using System;
#endif
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InitblkPerformanceIssue
{
    public static class Program
    {
        public const long DUMMY_LENGTH = 0x1_0000; // 64MiB
        public const long NUMBER_OF_BYTES = 0x2_C70A_3D7F; // ~11.12GiB

        public static unsafe void Main()
        {
            Warmup();

            // Run
            IntPtr large_array = Marshal.AllocHGlobal(new IntPtr(NUMBER_OF_BYTES));

            DateTime startTime = DateTime.UtcNow;

            Clear((byte*)large_array, NUMBER_OF_BYTES);

            DateTime endTime = DateTime.UtcNow;

            Console.WriteLine("Elpased Time (ms): " + (endTime - startTime).TotalMilliseconds);

            Marshal.FreeHGlobal(large_array);

            // Prevent program from terminating
            Console.ReadLine();
        }

        // Perform JIT compilation by executing functions to be used as dummy data.
        [MethodImpl(MethodImplOptions.NoInlining)]
        private static unsafe void Warmup()
        {
            IntPtr array = Marshal.AllocHGlobal(new IntPtr(DUMMY_LENGTH));

            Clear((byte*)array, DUMMY_LENGTH);

            Marshal.FreeHGlobal(array);

            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine();
        }

        // ref: https://github.com/ekfvoddl3536/0SuperComicLibs/blob/x-amd64/2SuperComicLib.RuntimeMemoryMarshals.Managed/src/__scl/memblk/MemoryBlock.Clear.cs#L30
        public static unsafe void Clear(byte* ptr, ulong bytes)
        {
            const ulong SZ_300 = 0x300u;
            const long ALIGN8 = 0x7u;

            if (bytes == 0)
                return;

            // pointer = 'unknown', number of bytes = 'unknown'
            var aligned = ((long)ptr + ALIGN8) & ~ALIGN8;

            var cb = Math.Min((ulong)(aligned - (long)ptr), bytes);

            Unsafe.InitBlockUnaligned(ptr, 0, (uint)cb);

            bytes -= cb;

            cb = bytes & unchecked((ulong)~ALIGN8);

            // pointer = 'aligned', number of bytes = 'alilgned'
            if (cb > SZ_300)
                aligned = (long)ClearLarge768_internal((byte*)aligned, cb);
            else if (cb != 0)
            {
                Unsafe.InitBlock((byte*)aligned, 0, (uint)cb);
                aligned += (long)cb;
            }

            // pointer = 'aligned', number of bytes = 'unaligned'
            Unsafe.InitBlock((byte*)aligned, 0, (uint)(bytes & ALIGN8));
        }

        // ref: https://github.com/ekfvoddl3536/0SuperComicLibs/blob/x-amd64/2SuperComicLib.RuntimeMemoryMarshals.Managed/src/__scl/memblk/MemoryBlock.Clear.cs#L62
        private static unsafe byte* ClearLarge768_internal(byte* ptr, ulong nb)
        {
            const ulong SZ_300 = 0x300u;
            const ulong SZ_2GB = 1u << 31;

            Unsafe.InitBlock(ptr, 1, (uint)SZ_300);

            ptr += SZ_300;
            nb -= SZ_300;

            while (nb != 0)
            {
                var cb1 = Math.Min(nb, SZ_2GB);

                Unsafe.InitBlock(ptr, 0, (uint)cb1);

                ptr += cb1;
                nb -= cb1;
            }

            return ptr;
        }
    }
}