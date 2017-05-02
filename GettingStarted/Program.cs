using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			// Keep the console window open in debug mode.
			Console.WriteLine("Press any key to exit.");
			Console.ReadKey();
		}

		#region CodingRule
		public void CodingRule()
		{
			//코딩 규칙.

			/* 주석 규칙.
			코드 줄의 끝이 아닌 별도의 줄에 주석을 배치합니다.
			주석 텍스트는 대문자로 시작합니다.
			주석 텍스트 끝에는 마침표를 붙입니다.
			다음 코드에 나와 있는 것처럼 주석 구분 기호(//)와 주석 텍스트 사이에 공백을 하나 삽입합니다.
			// The following declaration creates a query. It does not run
            // the query.
			*/

			// 언어 지침.
			// 짧은 문자열 연결은  + 연산자를 사용합니다.
			string FirstName = "Min-Ho";
			string LastName = "Lee";
			string displayName = LastName + ", " + FirstName;

			// 많은 양의 텍스트는 StringBuilder를 사용합니다.
			var phrase = "lalalalalalalalalalalalalalalalalalalalalalalalalalalalalala";
			var manyPhrases = new StringBuilder();
			for(var i = 0; i < 10000; i++)
			{
				manyPhrases.Append(phrase);
			}
			//Console.WriteLine("tra" + manyPhrases);

			// 암시적으로 형식화한 지역 변수.
			// 할당 오른쪽에서 변수 형식이 명확하거나 정확한 형식이 중요하지 않으면 지역 변수에 대해 암시적 형식을 사용합니다.
			// When the type of a variable is clear from the context, use var 
			// in the declaration.
			var var1 = "This is clearly a string.";
			var var2 = 27;
			var var3 = Convert.ToInt32(Console.ReadLine());
			// 할당 오른쪽에서 변수 형식이 명확하지 않으면 var을 사용하지 않습니다.
			int var4 = ExampleClass.ResultSoFar();
			// 변수 이름을 사용하여 변수 형식을 지정하지 않습니다. 이렇게 하면 형식이 올바르게 지정되지 않을 수 있습니다.
			var inputInt = Console.ReadLine();
			Console.WriteLine(inputInt);
			//for 및 foreach 루프의 루프 변수 형식을 결정하려면 암시적 형식을 사용합니다.
			var syllable = "ha";
			var laugh = "";
			for(var i = 0; i < 10; i++)
			{
				laugh += syllable;
				Console.WriteLine(laugh);
			}

			foreach(var ch in laugh)
			{
				if(ch == 'h')
					Console.Write("H");
				else
					Console.Write(ch);
			}
			Console.WriteLine();

			// 부호 없는 데이터 형식.
			// 일반적으로는 부호 없는 형식 대신 int를 사용합니다.int는 C# 전체에서 일반적으로 사용되며, int를 사용하는 경우 다른 라이브러리와 보다 쉽게 상호 작용할 수 있습니다.

			// 배열.
			// 선언 줄에서 배열을 초기화할 때는 간결한 구문을 사용합니다.
			// Preferred syntax. Note that you cannot use var here instead of string[].
			string[] vowels1 = { "a", "e", "i", "o", "u" };

			// If you use explicit instantiation, you can use var.
			var vowels2 = new string[] { "a", "e", "i", "o", "u" };

			// If you specify an array size, you must initialize the elements one at a time.
			var vowels3 = new string[5];
			vowels3[0] = "a";
			vowels3[1] = "e";
			// And so on.

			// 대리자.
			// 대리자 형식의 인스턴스를 만들려면 간결한 구문을 사용합니다.
			// In the Main method, create an instance of Del.

			// Preferred: Create an instance of Del by using condensed syntax.
			Del exampleDel2 = DelMethod;

			// The following declaration uses the full syntax.
			Del exampleDel1 = new Del(DelMethod);

			// 예외 처리의 try-catch 및 using 문.
			// 대부분의 예외 처리에서는 try-catch 문을 사용합니다.
			int[] array = new int[] { 1, 2, 3 };
			int index = 0;
			try
			{
				array[index] = 0;
			}
			catch(System.IndexOutOfRangeException ex)
			{
				Console.WriteLine("Index is out of range: {0}", index);
				throw;
			}
			// C# using 문을 사용하면 코드를 간소화할 수 있습니다. try-finally 블록의 코드가 finally 메서드 호출뿐인 Dispose 문이 있는 경우에는 using 문을 대신 사용합니다.
			// This try-finally statement only calls Dispose in the finally block.
			Font font1 = new Font("Arial", 10.0f);
			try
			{
				byte charset = font1.GdiCharSet;
			}
			finally
			{
				if(font1 != null)
				{
					((IDisposable)font1).Dispose();
				}
			}


			// You can do the same thing with a using statement.
			using(Font font2 = new Font("Arial", 10.0f))
			{
				byte charset = font2.GdiCharSet;
			}

			// && 및 || 연산자.
			// 예외를 방지하고 불필요한 비교를 건너뛰어 성능을 개선하려면 비교를 수행할 때 && 를 & 대신 사용하고 || 를 | 대신 사용합니다.

			// New 연산자/
			// 다음 선언에 나와 있는 것처럼 암시적 형식이 포함된 간결한 형태의 개체 인스턴스화를 사용합니다.
			var instance1 = new ExampleClass();
			// 위의 줄은 다음 선언과 동일합니다.
			ExampleClass instance2 = new ExampleClass();
			// 개체를 간편하게 만들려면 개체 이니셜라이저를 사용합니다.
			// Object initializer.
			var instance3 = new ExampleClass
			{
				Name = "Desktop",
				ID = 37414,
				Location = "Redmond",
				Age = 2.3
			};

			// Default constructor and assignment statements.
			var instance4 = new ExampleClass();
			instance4.Name = "Desktop";
			instance4.ID = 37414;
			instance4.Location = "Redmond";
			instance4.Age = 2.3;

			// 이벤트 처리.
			// 나중에 제거할 필요가 없는 이벤트 처리기를 정의하는 경우 람다 식을 사용합니다.
			// You can use a lambda expression to define an event handler.
			this.Click += (s, e) =>
			{
				Console.WriteLine("Click");
			};

			// 정적 멤버.
			//ClassName.StaticMember와 같이 클래스 이름을 사용하여 정적 멤버를 호출합니다. 이렇게 하면 정적 액세스가 명확하게 표시되므로 코드를 보다 쉽게 읽을 수 있습니다. 파생 클래스 이름을 사용하여 기본 클래스에 정의된 정적 멤버를 정규화해서는 안 됩니다. 이 코드는 컴파일되기는 하지만 가독성이 떨어지며 나중에 파생 클래스와 이름이 같은 정적 멤버를 추가하면 코드가 손상될 수도 있습니다.

			// LINQ 쿼리.
			//쿼리 변수에 의미 있는 이름을 사용합니다. 다음 예제에서는 Seattle 거주 고객에 대해 seattleCustomers를 사용합니다.
			Customer customer1 = new Customer { City = "서울", Name = "이민호" };
			Customer customer2 = new Customer { City = "미국", Name = "탐크루즈" };
			Customer[] customers = new Customer[] { customer1, customer2 };

			var seattleCustomers = from cust in customers
								   where cust.City == "Seattle"
								   select cust.Name;

			// 별칭을 사용하여 익명 형식의 속성 이름 대 / 소문자를 올바르게 표시합니다(파스칼식 대 / 소문자 사용).
			Distributor dist1 = new Distributor { City = "서울", Name = "이민호" };
			Distributor dist2 = new Distributor { City = "미국", Name = "탐크루즈" };
			Distributor[] distributors = new Distributor[] { dist1, dist2 };
			var localDistributors =
				from customer in customers
				join distributor in distributors on customer.City equals distributor.City
				select new { Customer = customer, Distributor = distributor };
			// 결과의 속성 이름이 모호하면 속성 이름을 바꿉니다. 예를 들어 쿼리에서 고객 이름과 배포자 ID를 반환하는 경우 결과에서 이러한 정보를 Name 및 ID로 유지하는 대신 Name은 고객의 이름이고 ID는 배포자의 ID임을 명확하게 나타내도록 이름을 바꿉니다.
			var localDistributors2 =
				from cust in customers
				join dist in distributors on cust.City equals dist.City
				select new { CustomerName = cust.Name, DistributorID = dist.ID };
			// 쿼리 변수 및 범위 변수의 선언에서 암시적 형식을 사용합니다.
			var seattleCustomers2 = from cust in customers
									where cust.City == "Seattle"
									select cust.Name;
			// 위의 예제에 나와 있는 것처럼 from 절 아래의 쿼리 절을 정렬합니다.
			// 뒷부분의 쿼리 절이 필터링을 통해 범위가 좁아진 데이터 집합에 대해 작동하도록 다른 쿼리 절 앞에 where 절을 사용합니다.
			var seattleCustomers3 = from cust in customers
									where cust.City == "Seattle"
									orderby cust.Name
									select cust;
			// 내부 컬렉션에 액세스하려면 fromjoin 절 대신 여러 절을 사용합니다. 예를 들어 Student 개체 컬렉션이 각각 테스트 점수 컬렉션을 포함하는 경우 다음 쿼리를 실행하면 90점보다 높은 각 점수와 해당 점수를 받은 학생의 성이 반환됩니다.

			// Use a compound from to access the inner sequence within each element.
			Student student1 = new Student { LastName = "Park" };
			Student student2 = new Student { LastName = "Lee" };
			Student[] students = new Student[] { student1, student2 };
			var scoreQuery = from student in students
							 from score in student.Scores
							 where score > 90
							 select new { Last = student.LastName, score };
		}

		public class ExampleClass
		{
			public string Name;
			public long ID;
			public string Location;
			public double Age;

			public static int ResultSoFar()
			{
				return 0;
			}
		}

		// First, in class Program, define the delegate type and a method that  
		// has a matching signature.

		// Define the type.
		public delegate void Del(string message);

		// Define a method that has a matching signature.
		public static void DelMethod(string str)
		{
			Console.WriteLine("DelMethod argument: {0}", str);
		}

		public class Font : IDisposable
		{
			public Font(string text, float size)
			{
			}

			public byte GdiCharSet;

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		// Using a lambda expression shortens the following traditional definition.
		public delegate void ClickDelegate(string message);
		//public ClickDelegate Click;
		public EventHandler Click;
		public void Form1()
		{
			this.Click += new EventHandler(Form1_Click);
		}

		void Form1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Form1_Click");
		}

		public class Customer
		{
			public string City;
			public string Name;
		}
		public class Distributor
		{
			public long ID;
			public string City;
			public string Name;
		}

		public class Student
		{
			public string LastName;
			public int[] Scores;
		}
	} 
	#endregion


}
