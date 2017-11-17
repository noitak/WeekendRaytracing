using System;

namespace WeekendRaytracing
{
    class Background
    {
        int _nx = 200;
        int _ny = 100;
        public void Draw()
        {
            Console.WriteLine("P3");
            Console.WriteLine("{0} {1}", _nx, _ny);
            Console.WriteLine("255");

            Vec3 lowerLeftCorner = new Vec3(-2.0, -1.0, -1.0);
            Vec3 horizontal = new Vec3(4.0, 0.0, 0.0);
            Vec3 vertical = new Vec3(0.0, 2.0, 0.0);
            Vec3 origin = new Vec3(0.0, 0.0, 0.0);

            for (int j = _ny - 1; j >= 0; j--)
            {
                for (int i = 0; i < _nx; i++)
                {
                    double u = (double)i / (double)_nx;
                    double v = (double)j / (double)_ny;

                    Ray ray = new Ray(origin, lowerLeftCorner + (u * horizontal) + (v * vertical));

                    Vec3 color = Util.Color(ray);

                    int ir = (int)(255.99 * color.r);
                    int ig = (int)(255.99 * color.g);
                    int ib = (int)(255.99 * color.b);
                    Console.WriteLine("{0} {1} {2}", ir, ig, ib);
                }
            }
        }
    }
}