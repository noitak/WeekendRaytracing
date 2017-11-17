using System;

namespace WeekendRaytracing
{
    class Util
    {
        public static Vec3 Color(Ray ray)
        {
            // -1.0 < ray.Diraction < 1.0
            Vec3 unitDirection = Vec3.UnitVector(ray.Direction());

            // 0.0 < t < 1.0
            double t = 0.5 * (unitDirection.y + 1.0);

            // white -> blue
            // Lerp = (1 - t) * Begin + (t * End)
            return (1.0 - t) * new Vec3(1.0, 1.0, 1.0) + (t * new Vec3(0.5, 0.7, 1.0));
        }
    }
}