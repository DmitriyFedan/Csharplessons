using Xunit;
using System;
using WorkWith3dFigures;

namespace WorkWith3dFigure.test
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest() // ���� ���������� ������ ����
        {
            Box box = new(10);
            Assert.Equal(1000, box.Volume(), 3);
        }

        [Fact]
        public void CylinderVolumeTest() // ���� ���������� ������ �������� 
        {
            Cylinder cyl = new Cylinder(5, 2.5);
            Assert.Equal(98.17, cyl.Volume(), 3);
        }

        [Fact]
        public void PyramidVolumeTest() // ���� ���������� ������ ��������
        {
            Pyramid pyr = new Pyramid(13, 21);
            Assert.Equal(91.0, pyr.Volume(),3);
        }
        
        [Fact]
        public void BallVolumeTest() //  ��������� ���������� ������  �����
        { 
            Ball ball = new(5);
            Assert.Equal(392.69, ball.Volume(),3);
        }

        [Theory]  // ���� �� ������� ��������� �����  �������� �������
        [InlineData(10.0, 5.0)]
        public void TestShapesAddition( int containerSize, double ballradius)
        {
            Box container = new Box(containerSize);
            Ball ball = new Ball(ballradius);
            Assert.True(container.Add(ball));
        }

        [Fact]
        public void TestAddSomeFigures() // ���� ���������� ���������� ����� � ����������� ����������� ������
        {
            Box box = new(10);
            Cylinder cyl = new Cylinder(5, 2.5);
            Pyramid pyr = new Pyramid(13, 21);
            Ball ball = new Ball(2.5);
            Ball ball_2 = new Ball(500); // ����� ������� �����

            Assert.True(box.Add(cyl));
            Assert.True(box.Add(pyr));
            Assert.True(box.Add(ball));
            Assert.False(box.Add(ball_2)); // �������� �������� ������� ������� ������ ����� �������������������
        }

        [Theory]  // ���� �� ������� ��������� ����� ���� ������ ������� �������� �������  
        [InlineData(10.0, 20.0, 5.0)]
        public void TestErrorAddition(int containerSize, double cylHeight, double cylBaseRadius)
        {
            Box container = new Box(containerSize);
            Cylinder cyl = new Cylinder(cylHeight, cylBaseRadius);
            Assert.False(container.Add(cyl));
        }


    }
}