// See https://aka.ms/new-console-template for more information
// This is the class implementing our IReaderWriter<TData>
// but now we know that it is going to save and retrieve
// data to and from a file. We would not care about the
// implementation so don't give it too much thought.
public class FileReaderWriter<TData> : IReaderWriter<TData> where TData : Data
{
    public void Initialize() { throw new NotImplementedException(); }

    public TData Read(int dataId) { throw new NotImplementedException(); }

    public void Write(TData data) { throw new NotImplementedException(); }

    /// <summary>
    ///     Explicit implementation
    /// </summary>
    /// <param name="data"></param>
    void IReaderWriter.Write(Data data)
    {
        Write((TData)data);
    }

    /// <summary>
    ///     Explicit implementation
    /// </summary>
    /// <param name="dataId"></param>
    /// <returns></returns>
    Data IReaderWriter.Read(int dataId)
    {
        return Read(dataId);
    }
}