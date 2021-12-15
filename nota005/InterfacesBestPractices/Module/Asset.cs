public class Asset
{
    public IReaderWriter<AssetData> AssetReaderWriter { get; set; }

    public Asset()
    {
        this.AssetReaderWriter = new FileReaderWriter<AssetData>();
        this.AssetReaderWriter.Initialize();
        this.WriteSampleAsset();
    }

    private void WriteSampleAsset()
    {
        this.AssetReaderWriter.Write(
            new AssetData
            { 
                DataId = 2,
                DataDescription = "Some description.",
                AssetId = 5,
                AssetName = "Asset 5."
            });
    }

    public AssetData AssetById(int idAsset) => this.AssetReaderWriter.Read(idAsset);
}