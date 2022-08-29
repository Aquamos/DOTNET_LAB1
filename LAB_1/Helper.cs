using static System.Console;
using Data.Models;
using DiplomaSystem;
using System.Globalization;

namespace ConsoleApp
{
    public class Helper
    {
        public static DateTime GetDateFromConsole()
        {
            DateTime dt;
            string input;
            do
            {
                Clear();
                WriteLine("Please enter date in format dd-MM-yyyy: ");
                input = ReadLine();
            }
            while (!DateTime.TryParseExact(input, "dd.MM.yyyy", null, DateTimeStyles.None, out dt));

            return dt;
        }
        public static string GetStringFromConsole()
        {
            string input;
            do
            {
                Clear();
                WriteLine("Input: ");
                input = ReadLine();
            }
            while (String.IsNullOrEmpty(input));
            return input;
        }
    }
}
