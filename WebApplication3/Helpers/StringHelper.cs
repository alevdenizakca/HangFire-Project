using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Helpers
{
    public static class StringHelper
    {
        public static int ToInt(this string value)
        {
            int.TryParse(value, out int v);
            return v;
        }

        public static double ToDouble(this string value)
        {
            double.TryParse(value, out double v);
            return v;
        }

        public static float ToFloat(this string value)
        {
            float.TryParse(value, out float v);
            return v;
        }

        public static decimal ToDecimal(this string value)
        {
            decimal.TryParse(value, out decimal v);
            return v;
        }

        public static byte ToByte(this string value)
        {
            byte.TryParse(value, out byte v);
            return v;
        }

        public static long ToLong(this string value)
        {
            long.TryParse(value, out long v);
            return v;
        }

        public static bool ToBool(this string value)
        {
            bool.TryParse(value, out bool v);
            return v;
        }

        public static Guid ToGuid(this string value)
        {
            Guid.TryParse(value, out Guid v);
            return v;
        }

        public static string Base64Decode(string value)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(value);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}