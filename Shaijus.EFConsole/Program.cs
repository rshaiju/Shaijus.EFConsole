using Shaijus.EFDAL;
using System;
using System.Linq;

namespace Shaijus.EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ShaijusContext context = new ShaijusContext())
            {
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
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
