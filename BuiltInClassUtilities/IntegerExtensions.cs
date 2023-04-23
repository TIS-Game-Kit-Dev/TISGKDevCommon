using System;
using System.Collections.Generic;
using System.Text;

namespace TisGameKit.TisGameKitCommon.BuiltInClassUtilities
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// 循环取余，对于负数的处理如下
        /// -5 % 3 = 1
        /// </summary>
        public static uint LoopModular(this int value, uint modular)
        {
            if (value >= 0)
            {
                return (uint)value % modular;
            }
            value = -value;
            var result = value % modular;
            return ((uint)(modular - result));
        }
    }
}
