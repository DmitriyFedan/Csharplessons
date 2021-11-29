using Xunit;
using System;
using WorkWith3dFigures;

namespace WorkWith3dFigure.test
{
    public class UnitTestShapes
    {
        [Fact]
        public void BoxVolumeTest()
        {
            Box box = new Box(10);

            double volume = box.Volume();

            Assert.Equal(1000, volume, 5);
        }

        [Fact]
        public void BallVolumeTest()
        { 
            Ball ball = new Ball(20.0);
            double bal_voll = ball.Volume();

            Assert.Equal()
        }

    }
}