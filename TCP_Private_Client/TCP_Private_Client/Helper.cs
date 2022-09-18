using System;

namespace TCP_Private_Client
{
    public static class Helper
    {
        public static string ParseAttribute(string data, string key)
        {
            if (string.IsNullOrEmpty(data) || string.IsNullOrEmpty(key))
                return "";
            
            if (data.Contains(key+"="))
            {
                var i1 = data.IndexOf(key+"=") + key.Length+1;
                var sub= data.Substring(i1);
                var i2 =  (sub[0] != '[') ? sub.IndexOf(',') : sub.Length  ;
                var name = (i2 != -1) ? sub.Substring(0, i2) : sub;
                return name;
            }
            return "";
        }

        public static string[] ParseArray(string data)
        {
            if (string.IsNullOrEmpty(data)) return Array.Empty<string>();
            if (data[0] == '[') data = data.Remove(0, 1);
            if (data[data.Length-1] == ']') data = data.Remove(data.Length - 1, 1);
            if (string.IsNullOrEmpty(data)) return Array.Empty<string>();
            return data.Split(',');
        }
    }
}