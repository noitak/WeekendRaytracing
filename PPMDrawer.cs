using System;

namespace WeekendRaytracing
{
    class PPMDrawer
    {
        protected void drawHeader(int nx, int ny)
        {
            Console.WriteLine("P3");
            Console.WriteLine("{0} {1}", nx, ny);
            Console.WriteLine("255");
        }

        public virtual void Draw()
        {
        }
    }
}