using System;
using System.Collections.Generic;
using Foundation;

namespace XamarinWebtrekkBindings
{
    public static class Converter
    {
        public static NSDictionary ConvertDictionaryToNSDictionary(IDictionary<string, string> dictionary)
        {
            var keys = new List<NSObject>();
            var values = new List<NSObject>();

            foreach(KeyValuePair<string, string> entry in dictionary) {
                keys.Add(NSObject.FromObject(entry.Key));
                values.Add(NSObject.FromObject(entry.Value));
            }

            return NSDictionary.FromObjectsAndKeys(values.ToArray(), keys.ToArray());
        }
    }
}
