using System;
using System.Linq;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			/*public static System.Collections.Generic.IEnumerable<TResult> 
			 * Zip<TFirst, TSecond, TResult>(
			 * this System.Collections.Generic.IEnumerable<TFirst> first, 
			 * System.Collections.Generic.IEnumerable<TSecond> second, 
			 * Func<TFirst, TSecond, TResult> resultSelector
			 * );
			 * The Above method is the Extension method of first type and Func is any Anonymous function which perform the delegate operation
			 */
			int[] numbers = { 1, 2, 3, 4 };
			string[] words = { "one", "two", "three" };
			var numbersAndWords = numbers.Zip(words, (first, second) => first + " " + second);

			foreach (var item in numbersAndWords)
				Console.WriteLine(item);
			Console.ReadKey();
		}
	}
}
