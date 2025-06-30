using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public class EnumHelper<T> where T : Enum
    {
        public static string GetPrettyPrintNames()
        {
            string[] names = GetNames();
            StringBuilder prettyNamesBuilder = new StringBuilder();
            for (int i = 0; i < names.Length; i++)
            {
                prettyNamesBuilder.AppendLine($"{i + 1}. {names[i]}");
            }

            return prettyNamesBuilder.ToString();
        }

        public static string GetPrettyPrintNames(List<T> values)
        {
            StringBuilder prettyNamesBuilder = new StringBuilder();
            for (int i = 0; i < values.Count; i++)
            {
                prettyNamesBuilder.AppendLine($"{i + 1}. {values[i]}");
            }

            return prettyNamesBuilder.ToString();
        }

        public static T[] GetValues() => (T[])Enum.GetValues(typeof(T));
        public static string[] GetNames() => Enum.GetNames(typeof(T));
        public static int Count => GetValues().Length;

        public static T GetValue(int index) => GetValues()[index];
    }
}
