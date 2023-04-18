using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace TisGameKit.TisGameKitCommon.ReflectionUtilities
{
    public static class ReflectionUtilities
    {
        /// <summary>
        /// 非静态公共成员
        /// </summary>
        public static BindingFlags PublicInstance = BindingFlags.Public | BindingFlags.Instance;

        /// <summary>
        /// 非静态公共声明成员（即不包含继承来的成员）
        /// </summary>
        public static BindingFlags DeclaredPublicInstance = PublicInstance | BindingFlags.DeclaredOnly;
    }
}
