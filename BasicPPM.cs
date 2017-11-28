using System;
using System.IO;

namespace WeekendRaytracing
{
    class BasicPPM : PPMDrawer
    {
        int _nx = 200;
        int _ny = 100;

        public BasicPPM(StreamWriter writer) : base(writer)
        {
        }

        public override void Draw()
        {
            base.drawHeader(_nx, _ny);

            for (int j = _ny - 1; j >= 0; j--)
            {
                for (int i = 0; i < _nx; i++)
                {
                    Vec3 vec3 = new Vec3((double)i / (double)_nx, (double)j / (double)_ny, 0.2);
                    int ir = (int)(255.99 * vec3.r);
                    int ig = (int)(255.99 * vec3.g);
                    int ib = (int)(255.99 * vec3.b);
                    _writer.WriteLine("{0} {1} {2}", ir, ig, ib);
                }
            }
        }
    }
}