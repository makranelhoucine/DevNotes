public interface IReaderWriterInvariant<TEntity>
{
	TEntity Read();
	void Write(TEntity entity);
}
