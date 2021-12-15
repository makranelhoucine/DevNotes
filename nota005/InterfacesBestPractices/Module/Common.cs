public class Common
{
    public void Run(IReaderWriter readerWriter)
    {
        readerWriter.Initialize();
    }

    public static void RetriceFromBlob(IReaderWriter readerWriter, int dataId)
    {
        var data = readerWriter.Read(dataId);
    }

    public static void WriteToBlob(IReaderWriter readerWriter, Data data)
    {
        readerWriter.Write(data);
    }
}