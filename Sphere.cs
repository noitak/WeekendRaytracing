using System;

namespace WeekendRaytracing
{
    class Sphere
    {
        public Vec3 Center { get; private set; }
        public double Radius { get; private set; }

        public Sphere(Vec3 center, double radius)
        {
            this.Center = center;
            this.Radius = radius;
        }

        public bool IsHit(Ray ray)
        {
            Vec3 oc = ray.Origin() - this.Center;
            double a = Vec3.Dot(ray.Direction(), ray.Direction());
            double b = 2.0 * Vec3.Dot(oc, ray.Direction());
            double c = Vec3.Dot(oc, oc) - (this.Radius * this.Radius);
            double discriminant = (b * b) - (4.0 * a * c);
            return (discriminant >= 0);
        }

        public double GetHitTime(Ray ray)
        {
            Vec3 oc = ray.Origin() - this.Center;
            double a = Vec3.Dot(ray.Direction(), ray.Direction());
            double b = 2.0 * Vec3.Dot(oc, ray.Direction());
            double c = Vec3.Dot(oc, oc) - (this.Radius * this.Radius);
            double discriminant = (b * b) - (4.0 * a * c);
            if (discriminant < 0)
            {
                return -1.0;
            }
            else
            {
                return (-b - Math.Sqrt(discriminant)) / (2.0 * a);
            }
        }
    }
}