using System;

namespace WeekendRaytracing
{
    class Util
    {
        public static Vec3 Color(Ray ray)
        {
            Vec3 unitDirection = Vec3.UnitVector(ray.Direction());
            double t = 0.5 * (unitDirection.y + 1.0);
            return (1.0 - t) * new Vec3(1.0, 1.0, 1.0) + (t * new Vec3(0.5, 0.7, 1.0));
        }
    }
}