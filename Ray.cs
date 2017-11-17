using System;

namespace WeekendRaytracing
{
    class Ray
    {
        Vec3 _origin, _direction;
        public Ray(Vec3 origin, Vec3 direction)
        {
            _origin = origin;
            _direction = direction;
        }

        public Vec3 Origin()
        {
            return _origin;
        }

        public Vec3 Direction()
        {
            return _direction;
        }

        public Vec3 PointAtParameter(double t)
        {
            return _origin + (t * _direction);
        }
    }
}