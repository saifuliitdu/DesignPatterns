using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T entity)
        {
            Console.WriteLine("Adding {0}", entity);
        }

        public void Delete(T entity)
        {
            Console.WriteLine("Deleting {0}", entity);
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("Getting entities");
            return null;
        }

        public T GetById(int id)
        {
            Console.WriteLine("Getting entity {0}", id);
            return default(T);
        }

        public void Update(T entity)
        {
            Console.WriteLine("Updating {0}", entity);
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
