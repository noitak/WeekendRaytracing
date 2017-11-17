using System;

namespace WeekendRaytracing
{
    class BasicPPM
    {
        int _nx = 200;
        int _ny = 100;

        public void Print()
        {
            Console.WriteLine("P3");
            Console.WriteLine("{0} {1}", _nx, _ny);
            Console.WriteLine("255");

            for (int j = _ny - 1; j >= 0; j--)
            {
                for (int i = 0; i < _nx; i++)
                {
                    float r = (float)i / (float)_nx;
                    float g = (float)j / (float)_ny;
                    float b = 0.2f;
                    int ir = (int)(255.99 * r);
                    int ig = (int)(255.99 * g);
                    int ib = (int)(255.99 * b);
                    Console.WriteLine("{0} {1} {2}", ir, ig, ib);
                }
            }
        }
    }
}