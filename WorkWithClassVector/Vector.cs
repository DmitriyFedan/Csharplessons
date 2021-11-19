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

        /// <summary>
        /// Method find the length of passed vector
        /// </summary>
        /// <param name="v1"></param>
        /// <returns></returns>
        public static double VectorLength(Vector v1)
        {
            double lenth = Math.Sqrt(v1.x * v1.x +
                                     v1.y * v1.y +
                                     v1.z * v1.z);
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
            int res_y = v1.z * v2.x - v1.x * v2.z;
            int res_z = v1.x * v2.y - v1.y * v2.x;
            Vector resvect = new Vector(res_x, res_y, res_z);
            return resvect;
        }

        public static double AngleAmongVectors(Vector v1, Vector v2)
        {
            double angle = (ScalarProduct(v1, v2) /
                            (Math.Abs(Vector.VectorLength(v1)) *
                            (Math.Abs(Vector.VectorLength(v2)))));
            return angle;
        }

        public static Vector SumVectors(Vector v1, Vector v2)
        {
            Vector sumvector = new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            return sumvector;
        }
        public static Vector DiffVectors(Vector v1, Vector v2)
        {
            Vector diffvector = new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            return diffvector;
        }
    }

}
