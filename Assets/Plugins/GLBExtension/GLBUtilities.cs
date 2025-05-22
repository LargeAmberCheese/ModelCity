using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GLBExtensions.Utilities
{
    [Serializable]
    public class RlList<T> : IEnumerable<T>, IEnumerable
    {
        public IReadOnlyList<T> List => _list;
        [SerializeField, HideInInspector] private List<T> _list;

        public RlList(IEnumerable<T> collection)
        {
            _list = new List<T>(collection);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public static class GLBUtilities
    {
        public static T RandomElement<T>(this IReadOnlyList<T> list)
        {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }

        public static T PopRandomElement<T>(this IList<T> list)
        {
            var index = UnityEngine.Random.Range(0, list.Count);
            var item = list[index];
            list.RemoveAt(index);
            return item;
        }
        
        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = UnityEngine.Random.Range(0, i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
        }
    }
}