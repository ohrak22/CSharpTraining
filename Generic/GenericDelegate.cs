using System;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class GenericDelegate
	{
		public delegate void Delegate<T>(T obj);
		static Delegate<int> action;

		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Delegate ----------");

			action = Notify;
			action(10);
			action(20);
			action(30);

			Console.WriteLine("\n");
		}
		
		public static void Notify(int v)
		{
			Console.WriteLine("Notify: " + v);
		}
	}
}
