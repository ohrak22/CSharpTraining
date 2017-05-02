using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	interface IGenericInterface<T>
	{
		void Print(T value);
	}

	class Printer<T> : IGenericInterface<T>
	{
		public void Print(T value)
		{
			Console.WriteLine("Generic print: " + value);
		}
	}

	static class GenericInterface
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Interface ----------");

			Printer<int> printer1 = new Printer<int>();
			Printer<float> printer2 = new Printer<float>();
			Printer<string> printer3 = new Printer<string>();

			printer1.Print(1);
			printer2.Print(1.234f);
			printer3.Print("Test003");

			Console.WriteLine("\n");
		}
	}
	
}
