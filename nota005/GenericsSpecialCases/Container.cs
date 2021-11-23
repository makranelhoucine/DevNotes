


public class Container<T> : ContainerBase
{
    public Container() => InstanceCount++;
    public static int InstanceCount { get; private set; }

    /// <summary>
    ///     Normal method in a generic class
    /// </summary>
    /// <param name="item">Item to print</param>
    public void PrintItem(T item)
    {
        System.Console.WriteLine($"Item: {item}");
    }

    /// <summary>
    ///     Generic method in a generic class
    /// </summary>
    /// <param name="item">Item to print</param>
    public void PrintItem<TItem>(TItem item)
    {
        System.Console.WriteLine($"Item: {item}");
    }
}