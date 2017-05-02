using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class Program
	{
		public class GenericClass<T>
		{
			public T value;
			public GenericClass(T value)
			{
				this.value = value;
			}
		}
		static void Main(string[] args)
		{
			GenericWhere.Sample();
			GenericMethod.Sample();
			GenericClass.Sample();
			GenericInterface.Sample();
			GenericArray.Sample();
			GenericDelegate.Sample();
			GenericDefault.Sample();
		}
	}
}
