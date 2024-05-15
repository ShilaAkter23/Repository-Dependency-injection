using project_1278831.CheckDependencyInjection;
using project_1278831.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1278831
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositoryFactory repoFactory = new RepositoryFactory();
            Test_01 test = new Test_01(repoFactory);
            test.Run();
            Console.WriteLine();
            Console.WriteLine(">>>>Test-02<<<<");
            Console.WriteLine();
            Test_02 test2 = new Test_02();
            test2.Run(repoFactory);
            Console.ReadLine(); 
        }
    }
}
