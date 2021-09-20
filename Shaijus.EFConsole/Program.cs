using Shaijus.EFDAL;
using System;
using System.Linq;

namespace Shaijus.EFConsole
{
    class Program
    {
        private static DbType dbType = DbType.SqlServer;
        static void Main(string[] args)
        {
            ShaijusContext context;

            switch(dbType)
            {
                case DbType.MySql:
                    context = new ShaijusMySqlContext();
                    break;
                default:
                    context = new ShaijusSqlServerContext();
                    break;
            }

            
            var boxes = context.Boxes.ToList();
            Console.WriteLine("==========Boxes======");
            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: Length={box.Length}, Width={box.Width}, Height={box.Height}");
            }

            var cylinders = context.Cylinders.ToList();

            Console.WriteLine("==========Cylinders======");
            foreach (var cylinder in cylinders)
            {
                Console.WriteLine($"Cylinder: Height={cylinder.Height}, Radius={cylinder.Radius}");
            }

            context.Dispose();
            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private enum DbType
        {
            MySql,
            SqlServer
        }
    }
}
