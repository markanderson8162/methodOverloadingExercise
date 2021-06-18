using System;

namespace MethodOverLoadingExercise
{
	class Program
	{

		public static int Add(int a, int b)
		{
			return a + b;
		}

		public static double Add(double a, double b)
		{
			return a + b;
		}

		public static string Add(int a, int b, bool isTrue)
		{
			int sumAB = a + b;
			string letterS;
			if(isTrue == true && sumAB > 1)
			{
				letterS =  "s";
			}
			else
			{
				letterS = "";
			}
			return $"{sumAB} dollar{letterS}, which isn't a lot.";
		}

		static void Main(string[] args)
		{
			Console.WriteLine(Add(5, 3, true));
			Console.WriteLine(Add(0, 1, true));
		}
	}
}
