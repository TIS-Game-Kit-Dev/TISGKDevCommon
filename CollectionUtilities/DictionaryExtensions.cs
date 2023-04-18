using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TisGameKit.TisGameKitCommon.CollectionUtilities
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// 如果存在该key对应的元素，返回该元素，否则返回null
        /// </summary>
        public static T? GetIfExists<KeyType, T>(this Dictionary<KeyType, T> dictionary, KeyType key) where T : class
        {
            if (dictionary.TryGetValue(key, out T value))
            {
                return value;
            }
            return null;
        }

        /// <summary>
        /// 如果存在该key对应的元素，返回该元素，否则添加新元素并返回新元素
        /// </summary>
        public static T AddIfNotExists<KeyType, T>(this Dictionary<KeyType, T> dictionary, KeyType key, T value) where T : class
        {
            var existedValue = dictionary.GetIfExists(key);
            if (existedValue != null)
            {
                return existedValue;
            }
            dictionary.Add(key, value);
            return value;
        }

    }
}
