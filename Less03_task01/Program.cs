using System;

namespace Less03_task01
{
	class Program
	{
		static void Main(string[] args)
		{
			Derived inst = new Derived();
			Console.WriteLine("f1 = {0}\tf2 = {1}", inst.field1, inst.field2);

			Console.ReadKey();
		}
	}

	class Base
	{
		public string field1 = "base.f1";
		public string field2 = "base.f2";
	}
	class Derived : Base
    {
		public string field1 = "derived.f1";

	}
}
