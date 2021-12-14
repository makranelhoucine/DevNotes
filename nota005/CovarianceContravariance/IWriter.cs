public interface IWriter<in TEntity>
{
	void Write(TEntity entity);
}