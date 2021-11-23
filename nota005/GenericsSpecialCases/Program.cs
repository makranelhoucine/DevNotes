_ = new Container<string>();
_ = new Container<string>();
var container = new Container<int>();

System.Console.WriteLine(Container<string>.InstanceCount); // 2
System.Console.WriteLine(Container<int>.InstanceCount); // 1
System.Console.WriteLine(Container<string>.InstanceBaseCount);// 3
System.Console.WriteLine(Container<int>.InstanceBaseCount); // 3

container.PrintItem(1);
container.PrintItem<string>("hello");

System.Console.WriteLine(Add(5,7));
System.Console.WriteLine(Add(7.3,5.7));

static T Add<T>(T x, T y) where T : notnull
{
    dynamic a = x;
    dynamic b = y;
    return a + b;
}
