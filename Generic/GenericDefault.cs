using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class GenericDefault
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Default ----------");

			DefaultClass<int> d1 = new DefaultClass<int>();
			DefaultClass<string> d2 = new DefaultClass<string>();
			DefaultClass<TestClass> d3 = new DefaultClass<TestClass>();
			Console.WriteLine("default int: " + d1.GetDefault());
			Console.WriteLine("default string: " + d2.GetDefault());
			Console.WriteLine("default TestClass: " + d3.GetDefault());


			Console.WriteLine("\n");
		}

		class DefaultClass<T>
		{
			public T GetDefault()
			{
				return default(T);
			}
		}

		class TestClass
		{
		}
	}
}
