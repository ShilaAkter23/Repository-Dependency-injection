using project_1278831.Models;
using project_1278831.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1278831.FactoryPattern
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IGenericRepository<T> CreateRepository<T>() where T : Pizza
        {
            return new GenericRepository<T>();
        }
    }
}
