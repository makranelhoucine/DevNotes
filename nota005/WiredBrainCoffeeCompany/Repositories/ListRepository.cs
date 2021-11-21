using WiredBrainCoffeeCompany.Entites;

namespace WiredBrainCoffeeCompany.Repositories
{
    public class ListRepository<T> : IRepository<T> where T : class, IEntityBase, new()
    {
        private List<T> _elements = new();

        public T CreateElemen()
        {
            return new T();
        }

        public void Add(T element)
        {
            element.Id = _elements.Any() ? _elements.Max(el => el.Id) + 1 : 1;
            this._elements.Add(element);
        }

        public void Remove(T element)
        {
            this._elements.Remove(element);
        }

        public T? GetById(int id)
        {
            return _elements.Single(element => element.Id == id);
        }

        public void Save()
        {
            foreach (var e in this._elements)
            {
                System.Console.WriteLine(e);
            }
            
        }

        public IEnumerable<T> GetAll()
        {
            return _elements.ToList(); // return a copy
        }
    }
}