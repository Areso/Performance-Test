/*
 * Created by SharpDevelop.
 * User: PRG2
 * Date: 11.05.2016
 * Time: 14:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CSharpDevelop
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Performance test!");
			
			// TODO: Implement Functionality Here
			Int64 sum = 0;
			DateTime time1;
			DateTime time2;
			TimeSpan time3;
			string time3string;
			time1 = DateTime.Now;
			for (int i = 0; i < 1000000; i++)
				{
				    sum = sum + i;
					//Console.WriteLine(i);
				}
			time2 = DateTime.Now;
			time3 = time2 - time1;
			time3string = time3.ToString();
			Console.WriteLine(time3string);
			Console.WriteLine(sum);
		}
	}
}