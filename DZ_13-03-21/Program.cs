using System.Globalization;
using System;
using System.Linq;

namespace DZ_13_03_21
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();
			{
				Console.WriteLine("ДЗ 1");
				// Дано случайно число, вы должны вернуть цифры этого числа в
				// массиве в обратном порядке.
				int num = new Random().Next(123456, 1234567);
				Console.WriteLine(num);
				string numStr = num.ToString();

				var reversedNum = (from x in numStr select x).Reverse();
				Console.WriteLine($"[{string.Join(',', reversedNum)}]");
			}
			Console.WriteLine();
			Console.WriteLine();
			{
				Console.WriteLine("ДЗ 2");
				// Дан массив целых чисел. Вернуть массив, где первый элемент - это
				// количество положительных чисел, а второй элемент - сумма
				// отрицательных чисел. Если входной массив пустой или нулевой,
				// вернуть пустой массив.
				var nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
				Console.WriteLine($"[{string.Join(',', nums)}]");
				var posNums = from x in nums
							  where x > 0
							  select x;
				var negNums = from x in nums
							  where x < 0
							  select x;
				var rez = new int[0];
				if (posNums.Count() != 0 || negNums.Sum() != 0)
				{
					rez = new int[] { posNums.Count(), negNums.Sum() };
				}
				Console.WriteLine($"[{string.Join(',', rez)}]");
			}
			Console.WriteLine();
			Console.WriteLine();
			{
				Console.WriteLine("ДЗ 3");
				// Дан массив строк, вернуть отсортированный массив от самой короткой
				// до самой длинной строки.
				var strArr = new string[] { "Telescopes", "Glasses", "Eyes", "Monocles" };
				Console.WriteLine($"[{string.Join(',', strArr)}]");
				var sortedArr = from x in strArr
								orderby x.Length
								select x;
				Console.WriteLine($"[{string.Join(',', sortedArr)}]");

			}
			Console.WriteLine();
			Console.WriteLine();
			{
				Console.WriteLine("ДЗ 4");
				// Дан массив с некоторыми числами. Все числа равны, кроме одного.
				// Верните уникальное число.
				var nums = new int[] { 9, 1, 2, 3, 4, 5, 1, 2, 3, 4, 5, 6, 7, 7, 8, 8, 9 };
				Console.WriteLine($"[{string.Join(',', nums)}]");
				var uniqNum = nums.GroupBy(x => x)
										.Where(x => x.ToList().Count == 1)
										.Select(x => x.Key);
				Console.WriteLine($"[{string.Join(',', uniqNum)}]");
			}
			Console.WriteLine();
		}
	}
}
