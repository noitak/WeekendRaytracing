using System;

namespace WeekendRaytracing
{
    class Vec3
    {
        double[] _e;

        public Vec3(double e0, double e1, double e2)
        {
            _e = new double[3] { e0, e1, e2 };
        }

        public double x { get { return _e[0]; } }
        public double y { get { return _e[1]; } }
        public double z { get { return _e[2]; } }
        public double r { get { return _e[0]; } }
        public double g { get { return _e[1]; } }
        public double b { get { return _e[2]; } }

        public static Vec3 operator +(Vec3 a, Vec3 b)
        {
            return new Vec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vec3 operator -(Vec3 a, Vec3 b)
        {
            return new Vec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        public static Vec3 operator *(Vec3 a, Vec3 b)
        {
            return new Vec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vec3 operator *(double n, Vec3 v) {
            return new Vec3(v.x * n, v.y * n, v.z * n);
        }

        public static Vec3 operator /(Vec3 a, Vec3 b)
        {
            return new Vec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }

        public static Vec3 operator /(Vec3 v, double d) {
            return new Vec3(v.x / d, v.y / d, v.z / d);
        }

        public static Vec3 UnitVector(Vec3 v) {
            return v / v.Length();
        }

        public static double Dot(Vec3 v1, Vec3 v2)
        {
            return v1.x * v2.x + v1.y * v2.y + v1.z * v2.z;
        }
        

        public double Length()
        {
            return Math.Sqrt(SquaredLength());
        }

        public double SquaredLength()
        {
            return _e[0] * _e[0] + _e[1] * _e[1] + _e[2] * _e[2];
        }

        public void MakeUnitVector()
        {
            double k = 1.0 / Length();
            _e[0] *= k;
            _e[1] *= k;
            _e[2] *= k;
        }

    }
}