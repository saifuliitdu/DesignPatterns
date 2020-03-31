using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class LoggerRepository<T> : IRepository<T>
    {
        private readonly IRepository<T> _decorator;
        public LoggerRepository(IRepository<T> decorator)
        {
            _decorator = decorator;
        }
        private void Log(string msg, object arg = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, arg);
            Console.ResetColor();
        }
        public void Add(T entity)
        {
            Log("In decorator - Begore adding {0}", entity);
            _decorator.Add(entity);
            Log("In decorator - After adding {0}", entity);
        }

        public void Delete(T entity)
        {
            Log("In decorator - Before deleting {0}", entity);
            _decorator.Delete(entity);
            Log("In decorator - After deleting {0}", entity);
        }

        public IEnumerable<T> GetAll()
        {
            Log("In decorator - Before getting entities");
            var result = _decorator.GetAll();
            Log("In decorator - After getting entities");
            return result;
        }

        public T GetById(int id)
        {
            Log("In decorator - Before getting entity");
            var result = _decorator.GetById(id);
            Log("In decorator - After getting entity");
            return result;
        }

        public void Update(T entity)
        {
            Log("In decorator - Before updating {0}", entity);
            _decorator.Update(entity);
            Log("In decorator - After updating {0}", entity);
        }
    }
}
