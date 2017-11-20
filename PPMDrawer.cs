using System;

namespace WeekendRaytracing
{
    class PPMDrawer
    {
        int _nx = 200;
        int _ny = 100;

        Sphere _sphere = new Sphere(new Vec3(0.0, 0.0, -1.0), 0.5);

        protected void drawHeader(int nx, int ny)
        {
            Console.WriteLine("P3");
            Console.WriteLine("{0} {1}", nx, ny);
            Console.WriteLine("255");
        }

        public virtual void Draw()
        {
            drawHeader(_nx, _ny);

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

                    Vec3 color = getColor(ray);

                    int ir = (int)(255.99 * color.r);
                    int ig = (int)(255.99 * color.g);
                    int ib = (int)(255.99 * color.b);
                    Console.WriteLine("{0} {1} {2}", ir, ig, ib);
                }
            }
        }

        private Vec3 getColor(Ray ray)
        {
            if (_sphere.IsHit(ray))
            {
                return new Vec3(1.0, 0, 0);
            }
            return Background.Color(ray);
        }
    }
}