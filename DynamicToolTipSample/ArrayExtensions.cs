using System;

namespace DynamicToolTipSample
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty(this Array array)
        {
            return array is null || array.Length == 0;
        }
    }
}
