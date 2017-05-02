using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	static class GenericMethod
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Method ----------");
			Print(1);
			Print(1.123f);
			Print("Text");

			Print<int>(1);
			Print<float>(1.123f);
			Print<string>("Text");
			Console.WriteLine("\n");
		}

		static void Print(int A)
		{
			Console.WriteLine("int print: " + A);
		}
		static void Print(float A)
		{
			Console.WriteLine("float print: " + A);
		}
		static void Print(string A)
		{
			Console.WriteLine("string print: " + A);
		}

		static void Print<T>(T A)
		{
			Console.WriteLine("Generic print: " + A);
		}
	}
}
