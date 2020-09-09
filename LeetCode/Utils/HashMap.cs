using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Utils
{
    public class HashMap<TKey, TValue>
    {
        private Dictionary<TKey, TValue> map;

        public HashMap()
        {
            map = new Dictionary<TKey, TValue>();
        }

        public TValue Get(TKey key)
        {
            return map[key];
        }

        public TValue GetOrDefault(TKey key, TValue value)
        {
            return map.ContainsKey(key) ? map[key] : value;
        }

        public void Put(TKey key, TValue value)
        {
            if (map.ContainsKey(key))
            {
                map.Remove(key);
            }
            map.Add(key, value);
        }

        public void Remove(TKey key)
        {
            map.Remove(key);
        }

        public int Size()
        {
            return map.Count;
        }

        public bool ContainsKey(TKey key)
        {
            return map.ContainsKey(key);
        }

        public IEnumerable<TKey> Keys()
        {
            return map.Keys;
        }

        public IEnumerable<TValue> Values()
        {
            return map.Values;
        }
    }
}
