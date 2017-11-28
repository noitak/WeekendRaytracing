using System;
using System.IO;

namespace WeekendRaytracing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: dotnet run OUT.ppm");
                return;
            }
            var filePath = args[0];
            using (var writer = new StreamWriter(File.Create(filePath)))
            {
                PPMDrawer drawer = new PPMDrawer(writer);
                drawer.Draw();
            }
        }
    }
}
