StackDoubles();
StackStrings();
Console.ReadLine();

static void StackDoubles()
{
    var stack = new SimpleStack<double>();
    stack.Push(1.2);
    stack.Push(2.8);
    stack.Push(3.0);

    double sum = 0.0;

    while (stack.Count > 0)
    {
        var item = stack.Pop();
        Console.WriteLine($"Item: {item}");
        sum += item;
    }

    Console.WriteLine($"Sum: {sum}");
}

static void StackStrings()
{
    var stack = new Stack<string>();
    stack.Push("1.2");
    stack.Push("2.8");
    stack.Push("3.0");

    while (stack.Count > 0)
    {
        var item = stack.Pop();
        Console.WriteLine($"Item: {item}");
    }
}