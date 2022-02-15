


public class ContainerBase
{
    public ContainerBase() => InstanceBaseCount++;
    public static int InstanceBaseCount { get; private set; }
}
