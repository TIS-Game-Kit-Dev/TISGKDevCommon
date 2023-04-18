using System.Collections.Generic;

namespace TisGameKit.TisGameKitCommon.CommonUtilities
{
    /// <summary>
    /// 函数框架类，用于帮助实现更复杂的函数或者复用函数体
    /// </summary>
    public static class FunctionFrameworks
    {
        public delegate T Selector<RootType, T>(RootType rootType);

        /// <summary>
        /// 根据选择器和过滤器获取一组对象的相对对象集合
        /// </summary>
        public static Dictionary<RootType, MemberType> SelectMembers<RootType, MemberType>(
            IEnumerable<RootType> roots,
            Selector<RootType, MemberType> selectorFunc)
        {
            var result = new Dictionary<RootType, MemberType>();
            foreach (var root in roots)
            {
                var member = selectorFunc.Invoke(root);
                result.Add(root, member);
            }
            return result;
        }
    }
}
