using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class GenericArray
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Array ----------");

			float[] arr = new float[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f };
			List<int> list = new List<int>();
			for(int i = 0; i < 5; i++)
			{
				list.Add(i);
			}
			PrintArray<float>(arr);
			PrintArray<int>(list);

			Console.WriteLine("\n");
		}

		static void PrintArray<T>(IList<T> list)
		{
			foreach(T item in list)
			{
				Console.WriteLine("Item: " + item);
			}
		}
	}
}
