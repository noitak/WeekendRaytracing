using System;

namespace WeekendRaytracing
{
    class BasicPPM
    {
        int _nx = 200;
        int _ny = 100;

        public void Draw()
        {
            Console.WriteLine("P3");
            Console.WriteLine("{0} {1}", _nx, _ny);
            Console.WriteLine("255");

            for (int j = _ny - 1; j >= 0; j--)
            {
                for (int i = 0; i < _nx; i++)
                {
                    Vec3 vec3 = new Vec3((double)i / (double)_nx, (double)j / (double)_ny, 0.2);
                    int ir = (int)(255.99 * vec3.r);
                    int ig = (int)(255.99 * vec3.g);
                    int ib = (int)(255.99 * vec3.b);
                    Console.WriteLine("{0} {1} {2}", ir, ig, ib);
                }
            }
        }
    }
}