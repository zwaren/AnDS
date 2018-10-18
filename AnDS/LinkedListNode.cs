using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnDS
{
	internal class LinkedListNode<T>
	{
		public T t { get; set; }
		public LinkedListNode<T> next { get; set; }

		public LinkedListNode(T t, LinkedListNode<T> next)
		{
			this.t = t;
			this.next = next;
		}
		
	}
}
