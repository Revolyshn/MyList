using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brick
{
	class Brick<T>
	{
		public T value;

		public Brick<T> next;

		public Brick<T> prev;

		public static int Count;

		public Brick(T value)
		{
			this.value = value;
		}		
	}

	class MyList<T>
	{
		public Brick<T> prev;
		public Brick<T> head;
		public Brick<T> tail;
		public Brick<T> list;

		public void Add(Brick<T> newBrick)
		{
			Brick<T>.Count++;
			if (list != null)
			{
				GetLast().next = newBrick;
				GetLast().prev = prev;
				tail = GetLast();
				prev = GetLast();
				return;
			}
			
			list = newBrick;
			head = list;
			prev = list;
			tail = list;
		}

		public void PushFront(Brick<T> NewBrick)
		{
			Brick<T> brick = NewBrick;
			brick.next = head;
			head.prev = brick;
			head = brick;
		}

		public Brick<T> GetLast()
		{
			Brick<T> current = list;
			while(current.next != null)
			{
				current = current.next;
			}
			return current;

		}

		public void PrintBack()
		{
			Brick<T> Tail = tail;
			while (Tail != null)
			{
				Console.WriteLine(Tail.value);
				Tail = Tail.prev;
			}
			Console.WriteLine();
		}

		public void Print()
		{
			Brick<T> Head = head;
			while (Head != null)
			{
				Console.WriteLine(Head.value);
				Head = Head.next;
			}
			Console.WriteLine();
		}
	}
}
