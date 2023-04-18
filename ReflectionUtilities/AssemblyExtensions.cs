using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TisGameKit.TisGameKitCommon.CollectionUtilities;
using TisGameKit.TisGameKitCommon.CommonUtilities;

namespace TisGameKit.TisGameKitCommon.ReflectionUtilities
{
    public static class AssemblyExtensions
    {
        /// <summary>
        /// 获取程序集内带有该自定义标记的所有Type
        /// </summary>
        public static Dictionary<Type, AttributeType> GetTypesWithCustomAttribute<AttributeType>(this Assembly assembly) where AttributeType : Attribute
        {
            return FunctionFrameworks.SelectMembers(
                assembly.GetTypes(),
                t => t.GetCustomAttribute<AttributeType>());
        }

        /// <summary>
        /// 获取程序集内带有该自定义标记的所有Type及其上的所有同类标记
        /// </summary>
        public static Dictionary<Type, List<AttributeType>> GetTypesWithCustomAttributes<AttributeType>(this Assembly assembly) where AttributeType : Attribute
        {
            return FunctionFrameworks.SelectMembers(
                assembly.GetTypes(),
                t => t.GetCustomAttributes<AttributeType>().ToList());
        }
    }
}
