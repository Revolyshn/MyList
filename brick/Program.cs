using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brick
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> lst = new MyList<int>();

			lst.Add(new Brick<int>(1));
			lst.Add(new Brick<int>(2));
			lst.Add(new Brick<int>(3));
			lst.Add(new Brick<int>(4));
			lst.Add(new Brick<int>(5));
			lst.Add(new Brick<int>(6));
			lst.Add(new Brick<int>(7));
			lst.Add(new Brick<int>(8));
			lst.Add(new Brick<int>(9));

			lst.PushFront(new Brick<int>(100));
			lst.PopFront();
			lst.Print();

			lst.InsertBefore(4,new Brick<int>(34));

			Console.WriteLine();
			lst.Remove(3);

			lst.Print();

			
		}
	}
}
