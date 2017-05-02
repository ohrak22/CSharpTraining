using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	static class GenericClass
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Class ----------");
			// Not Generic Class
			IntClass intClass = new IntClass(2);
			FloatClass floatClass = new FloatClass(0.001f);
			StringClass stringClass = new StringClass("test001");
			Console.WriteLine("Int Class: " + intClass.value);
			Console.WriteLine("Float Class: " + floatClass.value);
			Console.WriteLine("String Class: " + stringClass.value);

			// Generic Class
			GenericClass<int> genericClass1 = new GenericClass<int>(2);
			GenericClass<float> genericClass2 = new GenericClass<float>(0.001f);
			GenericClass<string> genericClass3 = new GenericClass<string>("test002");
			Console.WriteLine("Generic Class: " + genericClass1.value);
			Console.WriteLine("Generic Class: " + genericClass2.value);
			Console.WriteLine("Generic Class: " + genericClass3.value);
			Console.WriteLine("\n");
		}
	}

	class GenericClass<T>
	{
		public T value;
		public GenericClass(T value)
		{
			this.value = value;
		}
	}

	#region Not Generic Class
	class IntClass
	{
		public int value;
		public IntClass(int value)
		{
			this.value = value;
		}
	}

	class FloatClass
	{
		public float value;
		public FloatClass(float value)
		{
			this.value = value;
		}
	}
	class StringClass
	{
		public string value;
		public StringClass(string value)
		{
			this.value = value;
		}
	} 
	#endregion
}
