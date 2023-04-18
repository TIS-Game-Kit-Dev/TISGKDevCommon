using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TisGameKit.TisGameKitCommon.CollectionUtilities;
using TisGameKit.TisGameKitCommon.CommonUtilities;

namespace TisGameKit.TisGameKitCommon.ReflectionUtilities
{
    public static class TypeExtensions
    {
        /// <summary>
        /// 获取该类型上带有该自定义标记的所有属性
        /// </summary>
        public static Dictionary<MemberType, T> GetPropertiesWithCustomAttribute<MemberType, T>(
            this Type type,
            FunctionFrameworks.Selector<Type, List<MemberType>> memberSelector,
            BindingFlags bindingFlags = BindingFlags.Default)
            where MemberType : MemberInfo
            where T : Attribute
        {
            return FunctionFrameworks.SelectMembers(
                memberSelector.Invoke(type),
                p => p.GetCustomAttribute<T>());
        }

        /// <summary>
        /// 获取该类型上带有该自定义标记的所有属性
        /// </summary>
        public static Dictionary<PropertyInfo, List<T>> GetPropertiesWithCustomAttributes<T>(this Type type, BindingFlags bindingFlags = BindingFlags.Default)
            where T : Attribute
        {
            return FunctionFrameworks.SelectMembers(
                type.GetProperties(bindingFlags),
                p => p.GetCustomAttributes<T>().ToList());
        }
    }
}
