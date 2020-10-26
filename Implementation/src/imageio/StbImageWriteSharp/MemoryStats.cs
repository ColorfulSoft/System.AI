using System.Threading;

namespace System
{

    namespace AI
    {

        public static partial class imageio
        {

            internal static partial class StbImageWriteSharp
            {

                public static class MemoryStats
                {

                    private static int _allocations;

                    public static int Allocations
                    {

                        get
                        {
                          return _allocations;
                        }

                    }

                    internal static void Allocated()
                    {
                        Interlocked.Increment(ref _allocations);
                    }

                    internal static void Freed()
                    {
                        Interlocked.Decrement(ref _allocations);
                    }

                }

            }

        }

    }

}
