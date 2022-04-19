﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilies = new Utilities();
            List<string> result = utilies.BuildList<string>("Ankara", "İzmir", "Adana");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilies.BuildList<Customer>(new Customer { FirstName = "Adem" }, new Customer { FirstName = "Mehmet" });

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadKey();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product:IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {
        //List<Product> GetAll();
        //Product Get(int id);
        //void Add(Product product);
        //void Delete(Product product);
        //void Update(Product product);
    }

    class Customer: IEntity
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Customer>
    {
        void Custom();
        //List<Customer> GetAll();
        //Customer Get(int id);
        //void Add(Customer product);
        //void Delete(Customer product);
        //void Update(Customer product);
    }

    class Student: IEntity
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Custom()
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }


}
