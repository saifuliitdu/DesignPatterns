using DecoratorDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("***\r\n Begin program - no logging\r\n");
            //IRepository<Customer> customerRepository =
            //  new Repository<Customer>();
            //var customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Customer 1",
            //    Address = "Address 1"
            //};
            //customerRepository.Add(customer);
            //customerRepository.Update(customer);
            //customerRepository.Delete(customer);
            //Console.WriteLine("\r\nEnd program - no logging\r\n***");
            //Console.ReadLine();

            Console.WriteLine("***\r\n Begin program - logging with decorator\r\n");
            // IRepository<Customer> customerRepository =
            //   new Repository<Customer>();
            IRepository<Customer> customerRepository =
              new LoggerRepository<Customer>(new Repository<Customer>());
            var customer = new Customer
            {
                Id = 1,
                Name = "Customer 1",
                Address = "Address 1"
            };
            customerRepository.Add(customer);
            customerRepository.Update(customer);
            customerRepository.Delete(customer);
            Console.WriteLine("\r\nEnd program - logging with decorator\r\n***");
            //Console.ReadLine();

            Console.WriteLine("***\r\n Begin program - logging with dynamic proxy\r\n");
            // IRepository<Customer> customerRepository =
            //   new Repository<Customer>();
            // IRepository<Customer> customerRepository =
            //   new LoggerRepository<Customer>(new Repository<Customer>());
            IRepository<Customer> customerRepository2 =
              RepositoryFactory.Create<Customer>();
            var customer2 = new Customer
            {
                Id = 1,
                Name = "Customer 1",
                Address = "Address 1"

            };
            customerRepository2.Add(customer);
            customerRepository2.Update(customer);
            customerRepository2.Delete(customer);
            Console.WriteLine("\r\nEnd program - logging with dynamic proxy\r\n***");
            //Console.ReadLine();

            Console.WriteLine("***\r\n Begin program - logging and authentication\r\n");
            Console.WriteLine("\r\nRunning as admin");
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("Administrator"), new[] { "ADMIN" });
            IRepository<Customer> customerRepository3 = RepositoryFactory.Create<Customer>();
            //var customer = new Customer
            //{
            //    Id = 1,
            //    Name = "Customer 1",
            //    Address = "Address 1"
            //};
            customerRepository3.Add(customer);
            customerRepository3.Update(customer);
            customerRepository3.Delete(customer);
            Console.WriteLine("\r\nRunning as user");
            Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("NormalUser"), new string[] { });
            customerRepository3.Add(customer);
            customerRepository3.Update(customer);
            customerRepository3.Delete(customer);
            Console.WriteLine("\r\nEnd program - logging and authentication\r\n***");
            Console.ReadLine();
        }
    }
}
