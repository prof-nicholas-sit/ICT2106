//
// ICT2106 Software Design
//
// Interface to be relased by constant dictionaries.
//
using System.Collections.Generic;

namespace ICT2106.ConstantDictionary
{
    interface IConstantDictionary<K, V>
    {
        bool ContainsKey(K key);
        bool ContainsValue(V value);
        bool Equals(object o);
        Dictionary<K, V>.Enumerator GetEnumerator();
        int GetHashCode();
        string ToString();
        bool TryGetValue(K key, out V defaultValue);
    }
}
