using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
	public class Node<V>
	{
		public bool deleted { get; set; }
		public int key { get; set; }
		public V value { get; set; }

		public Node(int key, V value)
		{
			this.deleted = false;
			this.key = key;
			this.value = value;
		}

		public override string ToString()
		{
			string del;
			if (deleted)
			{
				del = "Удалено";
			}
			else
			{
				del = "";
			}

			return key + ": " + value + " " + del;
		}
	}

	public class Chain<V>
	{
		Node<V>[] chain;

		public Chain()
		{
			chain = new Node<V>[10];
			for (int i = 0; i < 10; i++)
			{
				chain[i] = null;
			}
		}

		public void add(int key, V value)
		{
			int i;
			for (i = 0; i < 10 && chain[i] != null && !chain[i].deleted && chain[i].key != key; i++);
			if (i < 10) chain[i] = new Node<V>(key, value);
		}

		public void delete(int key)
		{
			for (int i = 0; i < 10 && chain[i] != null; i++)
			{
				if (chain[i].key == key)
				{
					chain[i].deleted = true;
					break;
				}
			}
		}

		public override string ToString()
		{
			return string.Join(" -> ", chain.Where(x => x != null));
		}
	}

	class SeparateСhainingHashTable<V>
	{
		public Chain<V>[] chains;
		public int len { get { return 10; } }

		public SeparateСhainingHashTable()
		{
			this.chains = new Chain<V>[len];
			for (int i = 0; i < len; i++)
			{
				chains[i] = new Chain<V>();
			}
		}

		public int insert(int key, V value)
		{
			int hash = key % len;
			chains[hash].add(key, value);
			return hash;

		}

		public int delete(int key)
		{
			int hash = key % len;
			chains[hash].delete(key);
			return hash;
		}
	}
}
