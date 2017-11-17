using System;

namespace WeekendRaytracing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PPMDrawer drawer = new Background();
            drawer.Draw();
        }
    }
}
