using System;

namespace WeekendRaytracing
{
    class Util
    {
        public static Vec3 Color(Ray ray)
        {
            // draw sphere
            if (IsHitSphere(new Vec3(0, 0, -1.0), 0.5, ray))
            {
                return new Vec3(1.0, 0, 0);
            }

            // -1.0 < ray.Diraction < 1.0
            Vec3 unitDirection = Vec3.UnitVector(ray.Direction());

            // 0.0 < t < 1.0
            double t = 0.5 * (unitDirection.y + 1.0);

            // white -> blue
            // Lerp = (1 - t) * Begin + (t * End)
            return (1.0 - t) * new Vec3(1.0, 1.0, 1.0) + (t * new Vec3(0.5, 0.7, 1.0));
        }

        public static bool IsHitSphere(Vec3 center, double radius, Ray ray)
        {
            Vec3 oc = ray.Origin() - center;
            double a = Vec3.Dot(ray.Direction(), ray.Direction());
            double b = 2.0 * Vec3.Dot(oc, ray.Direction());
            double c = Vec3.Dot(oc, oc) - (radius * radius);
            double discriminant = (b * b) - (4.0 * a * c);
            return (discriminant >= 0);
        }
    }
}