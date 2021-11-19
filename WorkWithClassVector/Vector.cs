using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClassVector
{
    internal class Vector
    {
        public readonly double x;
        public readonly double y;
        public readonly double z;

        public Vector(double x, double y, double z)
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
            return Math.Round(lenth, 2);
        }

        /// <summary>
        /// считает скалярное произведение двух переданных векторов
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double ScalarProduct(Vector v1, Vector v2)
        {

            double scalar = (v1.x * v2.x +
                          v1.y * v2.y +
                          v1.z * v2.z);
            return Math.Round(scalar, 2);
        }
        
        /// <summary>
        /// возвращает результирующий вектор - результат  векторного произведения двух переданных векторов
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector VectorProduct(Vector v1, Vector v2)
        {
            double res_x = v1.y * v2.z - v1.z * v2.y;
            double res_y = v1.z * v2.x - v1.x * v2.z;
            double res_z = v1.x * v2.y - v1.y * v2.x;
            Vector resvect = new Vector(res_x, res_y, res_z);
            return resvect;
        }

        /// <summary>
        /// возвращает  косинус угла между двумя переданными векторами
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static double AngleAmongVectors(Vector v1, Vector v2)
        {
            double angle = (ScalarProduct(v1, v2) /
                            (Math.Abs(Vector.VectorLength(v1)) *
                            (Math.Abs(Vector.VectorLength(v2)))));
            return Math.Round(angle, 2);
        }

        /// <summary>
        /// возвращает  вектор  полученный в резльтате суммы переданных векторов 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector SumVectors(Vector v1, Vector v2)
        {
            Vector sumvector = new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
            return sumvector;
        }

        /// <summary>
        /// возвращает  вектор  полученный в резльтате разности переданных векторов 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static Vector DiffVectors(Vector v1, Vector v2)
        {
            Vector diffvector = new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
            return diffvector;
        }

        /// <summary>
        /// строковое представление координат вектора в формате Координаты вектора (x,y,z)
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static string StringInfo(Vector vector)
        {
            string info = ($"Координаты вектора ({vector.x},{vector.y},{vector.z})");
            return info;
        }
    }

}
