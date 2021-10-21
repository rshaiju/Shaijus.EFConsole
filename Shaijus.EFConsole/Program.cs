using Shaijus.EFDAL;
using System;
using System.Linq;
using System.Data.Entity;

namespace Shaijus.EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiLevelIncludeTester.Test();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
