using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnDS
{
	class Queue<T>
	{
		LinkedList<T> ll;

		public Queue()
		{
			this.ll = new LinkedList<T>();
		}

		public void push(T t)
		{
			ll.addToTail(t);
		}

		public T pop()
		{
			if (ll.Head != null)
			{
				var item = ll.Head;
				ll.delFromHead();
				return item.t;
			}
			return default(T);
			
		}

		public override string ToString()
		{
			return ll.ToString();
		}
	}
}
