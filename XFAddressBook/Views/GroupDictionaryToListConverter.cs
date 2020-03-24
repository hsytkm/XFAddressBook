using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace XFAddressBook.Views
{
    class GroupDictionaryToListConverter : IValueConverter
    {
        // IDictionary<string, T> を IList<object> に変換
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var dictionary = value.ToDictionary<string, object>();
            if (dictionary != null)
            {
                var list = new List<object>();
                foreach (var group in dictionary)
                {
                    if (group.Value is IEnumerable<object> items)
                    {
                        list.Add(new GroupTitleInList(group.Key));
                        list.AddRange(items);
                    }
                }
                return list;
            }
            throw new NotSupportedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotSupportedException();
    }

    // How to convert object to Dictionary<TKey, TValue> in C#?
    // https://stackoverflow.com/questions/11576886/how-to-convert-object-to-dictionarytkey-tvalue-in-c
    static class IDictionaryExtension
    {
        public static IDictionary<TKey, TValue> ToDictionary<TKey, TValue>(this object obj)
        {
            if (obj is IDictionary<TKey, TValue> sourceDictionary)
                return sourceDictionary;

            if (obj is IDictionary baseDictionary)
            {
                var dictionary = new Dictionary<TKey, TValue>();
                foreach (DictionaryEntry keyValue in baseDictionary)
                {
                    if (!(keyValue.Value is TValue))
                    {
                        // value is not TKey. perhaps throw an exception
                        return null;
                    }
                    if (!(keyValue.Key is TKey))
                    {
                        // value is not TValue. perhaps throw an exception
                        return null;
                    }

                    dictionary.Add((TKey)keyValue.Key, (TValue)keyValue.Value);
                }
                return dictionary;
            }
            // object is not a dictionary. perhaps throw an exception
            return null;
        }
    }
}