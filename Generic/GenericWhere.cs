using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
	class GenericWhere
	{
		public static void Sample()
		{
			Console.WriteLine("---------- Generic.Where ----------");

			Employee emp = new Employee();
			emp.Name = "Test001";
			SubEmployee<Employee> class1 = new SubEmployee<Employee>(emp);
			class1.Print();

			GenericStruct<Struct> gs = new GenericStruct<Struct>(); // ok.
			//GenericStruct<Class> gs_error = new GenericStruct<Class>(); // error
			GenericClass<Class> gc = new GenericClass<Class>(); // ok.
			//GenericClass<Struct> gc_error = new GenericClass<Struct>(); // error
			GenericNew<New> gn = new GenericNew<New>(); // ok.
			//GenericNew<Interface> gn_error = new GenericNew<Interface>(); // error
			GenericBase<Base> gb = new GenericBase<Base>(); // ok.
			//GenericBase<Class> gb_error = new GenericBase<Class>(); // error
			GenericInterface<Interface> gi = new GenericInterface<Interface>(); // ok
			//GenericInterface<Class> gi_error = new GenericInterface<Class>(); // error
			GenericU<TClass, UClass> gu = new GenericU<TClass, UClass>(); // ok
			//GenericU<VClass, UClass> gu_error = new GenericU<VClass, UClass>(); // error

			Console.WriteLine("\n");
		}

		public class Employee
		{
			public string Name { get; set; }

		}

		// 제약 조건을 사용하면 형식 T의 모든 항목이 항상 Employee 개체이거나 Employee에서 상속된 개체이므로 
		// 제네릭 클래스에서 Employee.Name 속성을 사용할 수 있습니다.
		public class SubEmployee<T> where T : Employee
		{
			private T data;
			public SubEmployee(T data)
			{
				this.data = data;
			}

			public void Print()
			{
				Console.WriteLine(data.Name);
			}
		}

		//where T: struct 형식 인수가 값 형식이어야 합니다.Nullable를 제외한 임의의 값 형식을 지정할 수 있습니다.자세한 내용은 Nullable 형식 사용를 참조하십시오.
		public struct Struct { }
		public class GenericStruct<T> where T : struct { }
		
		
		//where T : class 형식 인수가 참조 형식이어야 합니다.이는 모든 클래스, 인터페이스, 대리자 또는 배열 형식에도 적용됩니다.
		public class Class { }
		public class GenericClass<T> where T : class { }


		//where T : new()	형식 인수가 매개 변수 없는 공용 생성자여야 합니다.다른 제약 조건과 함께 사용하는 경우 new() 제약 조건은 마지막에 지정해야 합니다.
		public class New { }
		public class GenericNew<T> where T : new() { }


		//where T : <기본 클래스 이름>	형식 인수가 지정된 기본 클래스이거나 지정된 기본 클래스에서 파생되어야 합니다.
		public class Base { }
		public class GenericBase<T> where T : Base { }


		//where T : <인터페이스 이름>	형식 인수가 지정된 인터페이스이거나 지정된 인터페이스를 구현해야 합니다. 여러 인터페이스 제약 조건을 지정할 수 있습니다.제한하는 인터페이스는 제네릭이 될 수도 있습니다.
		public interface Interface { }
		public class GenericInterface<T> where T : Interface { }


		//where T : U T에 대해 지정한 형식 인수가 U에 대해 지정한 인수이거나 이 인수에서 파생되어야 합니다.
		public class UClass { }
		public class TClass : UClass { }
		public class VClass { }
		public class GenericU<T, U> where T : U { }
	}


}
