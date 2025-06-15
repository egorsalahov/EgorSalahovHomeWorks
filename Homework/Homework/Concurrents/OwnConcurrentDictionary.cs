using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Concurrents
{
    internal class OwnConcurrentDictionary<TKey, TValue>
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        object locker = new object();

        public int Count
        {
            get
            {
                lock (locker)
                {
                    return dict.Count;
                }
            }
        }

        public void Add(TKey key, TValue value)
        {
            lock (locker)
            {
                dict[key] = value;
            }
        }

        public bool Remove(TKey key)
        {
            lock (locker)
            {
                return dict.Remove(key);
            }
        }

        public bool Get(TKey key, TValue value)
        {
            lock (locker)
            {
                return dict.TryGetValue(key, out value); //out ибо valuetype
            }
        }

        public void Update(TKey key, TValue newValue)
        {
            lock (locker)
            {
                if (dict.ContainsKey(key))
                {
                    dict[key] = newValue;
                }
            }
        }
    }
}
