namespace Stack;
public class StackDemo
{
	int tos;
	int []stack;
	int MaxSize;

	void createStack(int size)
	{
		tos = -1;
		MaxSize = size;
		stack = new int[MaxSize];
	}

	void push(int value)
	{
		++tos;
		stack[tos] = value;
	}

	Boolean isFull()
	{
		if (tos == MaxSize -1)
		{
			return true;
		}
		return false;
	}

	int pop()
	{
		int temp = stack[tos];
		--tos;
		return temp;
	}

	Boolean isEmpty()
	{
		if(tos == -1)
		{
			return true;
		}
		return false;
	}

	int peek()
	{
		return stack[tos];
	}

	void printStack()
	{
		for(int i = tos; i > -1; --i)
		{
			System.Console.WriteLine(stack[i]);
		}
	}
}