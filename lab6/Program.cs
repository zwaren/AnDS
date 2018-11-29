using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Stack:");
			Stack<int> myStack = new Stack<int>();
			int k = 0;
			TimeSpan ts;
			Stopwatch stopWatch;
			for (int i = 10; i <= 1000000; i = i * 10)
			{
				Console.WriteLine(i + " элементов");
				stopWatch = new Stopwatch();
				stopWatch.Start();
				k = 0;
				while (k < i)
				{

					myStack.Push(k);
					k++;
				}

				stopWatch.Stop();
				ts = new TimeSpan();
				ts = stopWatch.Elapsed;
				string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);
				stopWatch.Restart();
				k = 0;

				while (i < 0)
				{
					myStack.Pop();
					k++;
				}
				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);

			}
			Console.WriteLine("\n");

			Console.WriteLine("Queue:");
			Queue<int> numbers = new Queue<int>();
			ts = new TimeSpan();
			for (int i = 10; i <= 10000000; i = i * 10)
			{
				Console.WriteLine(i + " элементов");
				stopWatch = new Stopwatch();
				stopWatch.Start();
				k = 0;
				while (k < i)
				{
					numbers.Enqueue(k);
					k++;
				}

				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);
				stopWatch.Restart();
				k = 0;


				while (k < i)
				{
					numbers.Dequeue();
					k++;
				}
				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);

			}

			Console.WriteLine("\n");

			Console.WriteLine("LinkedList:");

			LinkedList<int> dinosaurs = new LinkedList<int>();
			k = 0;
			stopWatch = new Stopwatch();
			ts = new TimeSpan();
			for (int i = 10; i <= 1000000; i = i * 10)
			{
				Console.WriteLine(i + " элементов");
				stopWatch = new Stopwatch();
				stopWatch.Start();
				k = 0;
				while (k < i)
				{
					dinosaurs.AddLast(k);
					k++;
				}
				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				string elapsedTime = String.Format("{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);

				stopWatch.Restart();
				k = 0;
				while (k < i)
				{
					dinosaurs.Remove(k);
					k++;
				}
				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				elapsedTime = String.Format("{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);
			}

			Console.WriteLine("\n");

			Console.WriteLine("ArrayList:");

			ArrayList myAL = new ArrayList();

			k = 0;
			stopWatch = new Stopwatch();
			for (int i = 10; i <= 10000000; i = i * 10)
			{
				Console.WriteLine(i + " элементов");
				stopWatch = new Stopwatch();
				stopWatch.Start();
				k = 0;
				while (k < i)
				{
					myAL.Add(k);
					k++;
				}
				stopWatch.Stop();
				ts = new TimeSpan();
				ts = stopWatch.Elapsed;
				string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);
				stopWatch.Restart();
				k = 0;
				while (i < 0)
				{
					myAL.Remove(k);
					k++;
				}
				stopWatch.Stop();
				ts = stopWatch.Elapsed;
				elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
				Console.WriteLine("Время работы " + stopWatch.Elapsed);
			}

			Console.WriteLine("\n");

			Console.WriteLine("Dictionary:");

			Dictionary<long, long> openWith = new Dictionary<long, long>();

			k = 0;
			long key = 0;
			stopWatch = new Stopwatch();
			for (int i = 10; i <= 1000000; i = i * 10)
			{
				Console.WriteLine(i + " элементов");
				stopWatch = new Stopwatch();
				stopWatch.Start();
				k = 0;
				key = 0;
				while (k < i)
				{
					key++;
					openWith.Add(key, k);
					k++;
				}
				stopWatch.Stop();

				Console.WriteLine("Время работы " + stopWatch.Elapsed);

				stopWatch.Restart();
				k = 0;
				while (k < i)
				{
					openWith.Remove(key--);
					k++;
				}
				stopWatch.Stop();

				Console.WriteLine("Время работы " + stopWatch.Elapsed);
				
			}

			Console.ReadKey();


		}		
	}
}
