// This class is representing the simple entity we are going to use
// in our example. 
// This is the interface we are going to focus on.
// It is an interface for something that would be able
// to read and write data to something that is ready
// to be used this way.
public interface IReaderWriter<TData> : IReaderWriter where TData : Data
{
    new TData Read(int dataId); // ethod hiding
    void Write(TData data);
}

public interface IReaderWriter
{
    void Initialize();
    Data Read(int dataId);
    void Write(Data data);
}
