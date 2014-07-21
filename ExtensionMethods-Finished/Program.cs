using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Build out the extension methods for:
            //  GreaterThan
            //  LessThan
            //  GreaterThanOrEqual
            //  LessThanOrEqual
            // Test those methods on the Person class below.
            var left = new Person("Bill", "Wagner");
            var right = new Person("Eric", "Lippert");
            Console.WriteLine(left.GreaterThan(right));
            Console.WriteLine(left.LessThan(right));
            Console.WriteLine(left.GreaterThanEqual(left));
            Console.WriteLine(left.LessThanEqual(left));


            // 2. Take the enum for status, build an 
            // extension method that converts the status to a colored foreground
            // and background brush that you would use for a log message with that 
            // status.  Use System.ConsoleColor for the color values.
            var status = Status.Error;
            Console.BackgroundColor = status.BackgroundColor();
            Console.ForegroundColor = status.ForegroundColor();
            Console.WriteLine("This is an error message");
            Console.ResetColor();

            // 3. If you have time, write an extension method on status that will
            // write a log message in the proper color.
            status = Status.Warning;
            status.WriteMessage("this is just a warning");
        }
    }

    public static class StatusExtensions
    {
        public static ConsoleColor BackgroundColor(this Status value)
        {
            switch (value)
            {
                case Status.Critical:
                    return ConsoleColor.DarkRed;
                case Status.Error:
                    return ConsoleColor.Red;
                case Status.Warning:
                    return ConsoleColor.Yellow;
                case Status.Information:
                case Status.Verbose:
                    return ConsoleColor.White;
                default:
                    return ConsoleColor.Black;
            }
        }

        public static ConsoleColor ForegroundColor(this Status value)
        {
            switch (value)
            {
                case Status.Critical:
                    return ConsoleColor.White;
                case Status.Error:
                    return ConsoleColor.White;
                case Status.Warning:
                    return ConsoleColor.Black;
                case Status.Information:
                case Status.Verbose:
                    return ConsoleColor.DarkGray;
                default:
                    return ConsoleColor.DarkGray;
            }
        }

        public static void WriteMessage(this Status value, string message)
        {
            Console.BackgroundColor = value.BackgroundColor();
            Console.ForegroundColor = value.ForegroundColor();
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    public enum Status
    {
        Critical,
        Error,
        Warning,
        Information,
        Verbose
    }

    public class Person : IComparable<Person>
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public Person(string first, string last)
        {
            FirstName = first;
            LastName = last;
        }

        #region IComparable<Person> Members

        public int CompareTo(Person other)
        {
            int lastCompare = LastName.CompareTo(other.LastName);
            return (lastCompare != 0) ? lastCompare :
                FirstName.CompareTo(other.FirstName);
        }

        #endregion
    }

    public static class Comparable
    {
        public static bool GreaterThan<T>(this T left, T right) where T : IComparable<T>
        {
            return left.CompareTo(right) > 0;
        }

        public static bool LessThan<T>(this T left, T right) where T : IComparable<T>
        {
            return left.CompareTo(right) < 0;
        }

        public static bool GreaterThanEqual<T>(this T left, T right) where T : IComparable<T>
        {
            return left.CompareTo(right) >= 0;
        }

        public static bool LessThanEqual<T>(this T left, T right) where T : IComparable<T>
        {
            return left.CompareTo(right) <= 0;
        }
    }
}
