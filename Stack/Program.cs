using Stack;
using System;
class Program
{
	static void Main(String[] args)
	{
		int choice, value;
		StackDemo obj = new StackDemo();
		Console.WriteLine("Enter the Size of Stack: ");
		int s = Convert.ToInt32(Console.ReadLine());
		obj.createStack(s);
	}
}