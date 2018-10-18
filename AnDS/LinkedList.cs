using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnDS
{
	class LinkedList<T>
	{
		public LinkedListNode<T> Head { get; private set; }
		public LinkedListNode<T> Tail {
			get
			{
				if (Head != null)
				{
					var curr = Head;
					while (curr.next != null)
					{
						curr = curr.next;
					}
					return curr;
				}
				else
				{
					return null;
				}
				
			}
		}

		public LinkedList(params T[] ts)
		{
			foreach (T t in ts)
			{
				Head = new LinkedListNode<T>(t, Head);
			}
		}

		public void addToHead(T t)
		{
			Head = new LinkedListNode<T>(t, Head);
		}

		public void addToTail(T t)
		{
			if (Tail != null)
			{
				Tail.next = new LinkedListNode<T>(t, null);
			}
			else
			{
				Head = new LinkedListNode<T>(t, null);
			}
		}

		public void delFromHead()
		{
			if (Head != null) Head = Head.next;
			
		}
		
		public override string ToString()
		{
			string str = "";
			LinkedListNode<T> curr = Head;
			while (curr != null)
			{
				str += curr.t + " ";
				curr = curr.next;
			}
			return str;
		}
	}
}
