using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
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

		public new string ToString()
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

	class QuadraticProbingHashTable<V>
	{
		public Node<V>[] vals;
		public int len { get { return 100; } }

		public QuadraticProbingHashTable()
		{
			this.vals = new Node<V>[len];
			for (int i = 0; i < len; i++)
			{
				vals[i] = null;
			}
		}

		public int find(int key)
		{
			int hash = key % len;
			int cur;
			for (int i = 0; i < 10; i++)
			{
				cur = (hash + (i * i)) % len;
				if (vals[cur] == null) return -1;
				if (vals[cur].key == key && !vals[cur].deleted) return cur;
			}
			return -1;
		}

		public int insert(int key, V value)
		{
			int check = find(key);
			if (check != -1)
			{
				vals[check].value = value;
				return check;
			}

			int hash = key % len;
			int cur;
			for (int i = 0; i < 10; i++)
			{
				cur = (hash + i * i) % len;
				if (vals[cur] == null || vals[cur].deleted)
				{
					vals[cur] = new Node<V>(key, value);
					return cur;
				}
			}
			return -1;
		}

		public int delete(int key)
		{
			var x = find(key);
			if (x != -1)
			{
				vals[x].deleted = true;
			}
			return x;
		}
		
	}
}
