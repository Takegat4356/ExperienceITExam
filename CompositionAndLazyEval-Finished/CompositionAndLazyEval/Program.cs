using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositionAndLazyEval
{
    class Program
    {
        static void Main(string[] args)
        {
            // write a query that:
            // 1. Generates 100 random integers.
            // 2. Uses only the even numbers.
            // 3. finds all the prime factors of each number
            // 4. builds a structure for each number that contains the number, and a list of all the prime factors
            //var sequence = from num in GenerateRandomInts(100)
            //               where num % 2 == 0
            //               select new { Number = num, Factors = Primes.PrimeFactors(num) };
            var generator = new Random();
            var sequence = Enumerable.Range(0,100).Log("Generated")
                .Select(_ => generator.Next(int.MaxValue))
                .Log("generated random")
                .Where(num =>
                    {
                        num.Log("Executing Where");
                        return num % 2 == 0;
                    })
                .Select(num =>
                    {
                        num.Log("Executing Select");
                        return new { Number = num, 
                            Factors = Primes.PrimeFactors(num) };
                    });

            foreach (var item in sequence)
            {
                Console.WriteLine("Factors of {0}", item.Number);
                foreach (var factor in item.Factors.Log("writing factors"))
                    Console.WriteLine(factor.Log("writing factor")); 

            }
        }

        private static IEnumerable<int> GenerateRandomInts(int size)
        {
            var gen = new Random();
            for (int i = 0; i < size; i++)
                yield return gen.Next(int.MaxValue).Log("generating random value"); ;
        }
    }

    public static class Extensions
    {
        public static T Log<T>(this T inputOutput, string message)
        {
            Console.WriteLine("Processing: {0}\tMessage:{1}", 
                inputOutput, message);
            return inputOutput;
        }
        public static IEnumerable<T> Log<T>(
            this IEnumerable<T> inputOutput, 
            string message)
        {
            foreach (T item in inputOutput)
            {
                Console.WriteLine("Processing: {0}\tMessage:{1}", 
                    item, message);
                yield return item;
            }
        }
    }

    public static class Primes
    {
        public static IEnumerable<int> PrimeFactors(int number)
        {
            return MorePrimeFactors(number, 2);
        }
        private static IEnumerable<int> MorePrimeFactors(int number, int currentFactor)
        {
            while (number % currentFactor != 0)
            {
                currentFactor++;
            }
            yield return currentFactor;
            // next bigger factor:
            if (number > currentFactor)
                foreach (int factors in MorePrimeFactors(number / currentFactor, currentFactor))
                    yield return factors;

        }

    }
}
