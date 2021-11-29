using Xunit;
using PolygonPerimetr;

namespace PolygonPerimetr.test
{
    public class PolygonTest
    {

        // test points  
        Point p1 = new Point("A", 1, 1);
        Point p2 = new Point("B", 2, 3);
        Point p3 = new Point("C", 5, 8);
        Point p4 = new Point("D", 13, 21);
        Point p5 = new Point("D", 34, 55);

        [Fact]
        //тестируем создание  четырехугольника и вычисление его периметра
        public void QudrangleTest()
        {
            Polygon quad = new Polygon(p1, p2, p3, p4);
            Assert.Equal(46.66, quad.Perimetr(), 3);
        }

        [Fact]
        //тестируем создание треугольника и вычисление его периметра
        public void TriangleTest()
        {
            Polygon triangle = new Polygon(p1, p2, p3);
            Assert.Equal(16.13, triangle.Perimetr(), 3);
        }

        [Fact]
        //тестируем создание пятиугольника и вычисление его периметра
        public void PentagonTest()
        {
            Polygon pentagon = new Polygon(p1, p2, p3, p4, p5);
            Assert.Equal(126.58, pentagon.Perimetr(), 3);
        }

        /*
        [Theory]
        [InlineData(p1, p2, p3)]  //  может принимать только значимые типы? 
        public void LengthSidetest(Point p_1, Point p_2, Point p_3)
        { 
            Polygon triangle2 =  new Polygon(p_1, p_2, p_3);
            double value = triangle2.SideLenght(p_1,p_2);
            Assert.Equal()
        }
  */
        [Fact]
        public void LengthSidetest() // теситруем вычисление длинны стороны треугольника
        {
            Polygon triangle2 = new Polygon(p1, p2, p3);
            double length = triangle2.SideLenght(p1, p2);
            Assert.Equal(2.236, length, 2);
        }
    }
}