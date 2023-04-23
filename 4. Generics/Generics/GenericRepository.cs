using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class GenericRepository<T> : IRepository<T> where T: Entity
    {
        readonly List<T> _values = new();

        public void Add(T item)
        {
            _values.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _values;
        }

        public T GetById(int id)
        {
            return _values.Single(item => item.Id == id);
        }

        public void Remove(T item)
        {
            _values.Remove(item);
        }

        public void Save()
        {

        }
    }
}
