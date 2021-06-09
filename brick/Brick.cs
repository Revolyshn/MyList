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

		public int index = 0;

		public void SetIndex(int index)
        {
			this.index = index;
        }


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
		public int index=0;


		//Добавление элемента в список
		public void Add(Brick<T> newBrick)
		{

			if (list != null)
			{
				index++;
				GetLast().SetIndex(index);
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

		//Добавление элемента в начало списка
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

		//Вывод списка на консоль(В обратном порядке)
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

		//Вывод списка на консоль
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

		//Удаление по элемента по айдишнику
		public void Remove(int index)
		{
			Brick<T> Head = head;
			Brick<T> rmv;
			for (int i = 0; i < index; i++)
			{
				Head = Head.next;
			}

			rmv = Head.next;
			Head = Head.prev;
			Head.next = rmv;

		}

		public void InsertBefore(int index, Brick<T> NewBrick)
        { 
			Brick<T> brick = NewBrick;
			Brick<T> Head = head;
			Brick<T> element;

			
			for (int i = 0; i < index - 1; i++)
			{
				Head = Head.next;
			}

			element = Head.next;
			Head.next = brick;
			brick.next = element;
        }

		public void InsertAfter(int index, Brick<T> NewBrick)
        {
			Brick<T> brick = NewBrick;
			Brick<T> Head = head;
			Brick<T> element;
			for (int i = 0; i < index + 1; i++)
			{
				Head = Head.next;
			}
			element = Head.prev;
			Head.next = brick;
			brick.next = element;
        }

		public T PopFront()
        {
			T remove;
			remove = head.value;
			head = head.next;
			head.prev = null;
			return remove;
        }

		public T PopBack()
        {
			T remove;
			remove = tail.value;
			tail = tail.prev;
			tail.next = null;
			return remove;
        }
	}
}
