using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void AreaOfCricle()
        {
          var expected = 12.56;
            var a = 2;
            var actual = Area(a) ;
            Assert.Equal(expected,actual); 
        }
        double Area(int x)
        {
            return 3.14*x*x;  
        }
        [Theory]
        [InlineData(12.56, 2)]
        [InlineData(78.5, -5 )]
        [InlineData(0.0, 0 )]
        public void AreaOfCricle1(double exp, int n)
        {
            Assert.Equal(exp, Area(n));
        }
        public void CircumferenceOfCircle()
        {
            var expected = 12.56;
            var b = 2;
            var actual = Area1(b);
            Assert.Equal(expected, actual);
        }
        double Area1(int s)
        {
            return 3.14*2*s;  
        }
        [Theory]
        [InlineData(12.56, 2)]
        [InlineData(37.68, 6 )]
        [InlineData(0.0, 0)]
        public void AreaOfCricle2(double exp, int n)
        {
            Assert.Equal(exp, Area1(n));
        }

    }
}
