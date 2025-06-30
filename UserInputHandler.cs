using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPS
{
    public static class UserInputHandler
    {
        public static bool HandleUserEnumSelection<T>(out T? res) where T : Enum
        {
            res = default;
            string userInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("Missing input.");
            }
            else if (userInput.Equals("q", StringComparison.InvariantCultureIgnoreCase))
            {
                Environment.Exit(0);
            }

            if (!int.TryParse(userInput, out int userInt))
            {
                Console.WriteLine("Invalid input.");
                return false;
            }

            if (userInt < 0 || userInt > EnumHelper<T>.Count)
            {
                Console.WriteLine("Invalid hand.");
                return false;
            }

            res = EnumHelper<T>.GetValue(--userInt);
            return true;
        }

    }
}
