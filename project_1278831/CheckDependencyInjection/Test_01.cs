using project_1278831.FactoryPattern;
using project_1278831.Models;
using project_1278831.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1278831.CheckDependencyInjection
{
    public class Test_01
    {
        IRepositoryFactory factory;
        public Test_01(IRepositoryFactory factory) { this.factory = factory; }
        public void Run()
        {
            IGenericRepository<VegPizza> repoV = factory.CreateRepository<VegPizza>();
            repoV.AddRange(new VegPizza[] {
              new VegPizza() { Id = 1, Name = "Margherita Pizza", Size="Personal or Small", Price=8.25, Stock="Available" },
               new VegPizza() { Id = 2, Name = "Vegetarian Deluxe Pizza", Size="Medium", Price=11.00, Stock="Available" },
               new VegPizza() { Id = 3, Name = "Spinach and Feta Pizza", Size="Large", Price=12.25, Stock="Available" },
               new VegPizza() { Id = 4, Name = "Greek Veggie Pizza", Size="Family Size", Price=15.00, Stock="Available" },
            });
            //GetAll
            Console.WriteLine("********************Vegetable Pizza********************");
            Console.WriteLine("GetAll");
            repoV.GetAll().ToList()
                .ForEach(v => Console.WriteLine($"ID:{v.Id}, Name: {v.Name}, Size{v.Size}, Price: ${v.Price}, Stock: {v.Stock}"));
            //Get
            Console.WriteLine("Get");
            var veg = repoV.Get(2);
            Console.WriteLine($"ID:{veg.Id}, Name: {veg.Name}, Size{veg.Size}, Price: ${veg.Price}, Stock: {veg.Stock}");
            //Update
            Console.WriteLine("Update");
            veg.Price = 12.50;
            repoV.Update(veg);
            repoV.GetAll().ToList()
                .ForEach(v => Console.WriteLine($"ID:{v.Id}, Name: {v.Name}, Size{v.Size}, Price: ${v.Price}, Stock: {v.Stock}"));
            //Delete
            Console.WriteLine("Delete");
            repoV.Delete(2);
            repoV.GetAll().ToList()
                .ForEach(v => Console.WriteLine($"ID:{v.Id}, Name: {v.Name}, Size{v.Size}, Price: ${v.Price}, Stock: {v.Stock}"));
            Console.WriteLine();

            Console.WriteLine("********************Non-Vegetable Pizza********************");
            IGenericRepository<NonVegPizza> repoNV = factory.CreateRepository<NonVegPizza>();
            repoNV.AddRange(new NonVegPizza[]
            {
               new NonVegPizza() { Id = 1, Name = "Meat Lovers Pizza", Size="Small/Medium/Large", Price=18.35, Stock="Available" },
               new NonVegPizza() { Id = 2, Name = "BBQ Chicken Pizza", Size="Medium", Price=20.50, Stock="Available" },
               new NonVegPizza() { Id = 3, Name = "Buffalo Chicken Pizza", Size="Large", Price=20.25, Stock="Available" },
               new NonVegPizza() { Id = 4, Name = "Seafood Delight Pizza", Size="Medium", Price=15.99, Stock="Available" },

            });
            //GetAll
            Console.WriteLine("GetAll");
            repoNV.GetAll().ToList()
                .ForEach(n => Console.WriteLine($"ID:{n.Id}, Name: {n.Name}, Size{n.Size}, Price: ${n.Price}, Stock: {n.Stock}"));
            //Get
            Console.WriteLine("Get");
            var nonveg = repoNV.Get(2);
            Console.WriteLine($"ID:{nonveg.Id}, Name: {nonveg.Name}, Size{nonveg.Size}, Price: ${nonveg.Price}, Stock: {nonveg.Stock}");
            //Update
            Console.WriteLine("Update");
            nonveg.Price = 18.50;
            repoNV.Update(nonveg);
            repoNV.GetAll().ToList()
                .ForEach(n => Console.WriteLine($"ID:{n.Id}, Name: {n.Name}, Size{n.Size}, Price: ${n.Price}, Stock: {n.Stock}"));
            //Delete
            Console.WriteLine("Delete");
            repoNV.Delete(2);
            repoNV.GetAll().ToList()
                .ForEach(n => Console.WriteLine($"ID:{n.Id}, Name: {n.Name}, Size{n.Size}, Price: ${n.Price}, Stock: {n.Stock}"));
        }
    }
}
