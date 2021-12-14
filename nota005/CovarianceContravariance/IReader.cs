public interface IReader<out TEntity>
{
	TEntity Read();
}