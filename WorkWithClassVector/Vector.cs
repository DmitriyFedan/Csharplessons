using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClassVector
{
    internal class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double VectorLength()
        {
            double lenth = Math.Sqrt(x * x + y * y + z * z);
            return lenth;
        }

        public static int ScalarProduct(Vector v1, Vector v2)
        {
            int scalar = (v1.x * v2.x +
                          v1.y * v2.y +
                          v1.z * v2.z);
            return scalar;
        }
        public static Vector VectorProduct(Vector v1, Vector v2)
        {
            int res_x = v1.y * v2.z - v1.z * v2.y;
            int res_y = v1.z*v2.x - v1.x * v2.z;
            int res_z = v1.x * v2.y - v1.y * v2.x;
            Vector resvect = new Vector(res_x, res_y, res_z);
            return resvect;
        }


    }

}
