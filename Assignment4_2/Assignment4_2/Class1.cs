using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2
{
    internal class Circle
    {
        private float radius;
        public float Radius { get => radius; set => radius = value; }

        public static float operator +(Circle a, Circle b)
        {
            float piApproximate = 22 / 7;
            float areaA = (a.radius * a.radius) * piApproximate;
            float areaB = (b.radius * b.radius) * piApproximate;
            float result = areaA + areaB;
            return result;
        }
        public static float operator -(Circle a, Circle b)
        {
            float piApproximate = 22 / 7;
            float areaA = (a.radius * a.radius) * piApproximate;
            float areaB = (b.radius * b.radius) * piApproximate;
            float result = areaA - areaB;
            return result;
        }
    }
}
