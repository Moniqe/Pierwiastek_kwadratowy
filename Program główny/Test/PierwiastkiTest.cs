using System;
using Xunit;
using Program_g³ówny;

namespace Test
{
    public class PierwiastkiTest
    {
        [Theory]
        [InlineData(2, 8, -10, 144)]
        [InlineData(3, 1, 6, -71)]
        [InlineData(1, 1, 1, -3)]
        [InlineData(1, 0, 0, 0)]

        public void calculateDelta_calcDelta_getTheValues(int a, int b, int c, double expect)
        {
            Równanie_kwadratowe qe = new Równanie_kwadratowe();
            double result = qe.calcDelta(a, b, c);
            Assert.Equal(expect, result);

        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaLessThanZero()
        {
            Równanie_kwadratowe qe = new Równanie_kwadratowe();
            qe.a = 1;
            qe.b = 0;
            qe.c = 1;
            //delta  < 0
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            Assert.Equal(qe.x0, 8);
            Assert.Equal(qe.x1, 16);
            Assert.Equal(qe.x2, 32);

        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaEqualZero()
        {
            Równanie_kwadratowe qe = new Równanie_kwadratowe();
            qe.a = 1;
            qe.b = 2;
            qe.c = 1;
            bool expect = false;
            // delta = 0 
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            expect = qe.x0 == -1;
            Assert.True(expect);

        }

        [Fact]
        public void choosingRightOption_calcDeltaZeros_deltaGreaterThanZero()
        {
            Równanie_kwadratowe qe = new Równanie_kwadratowe();
            qe.a = 1;
            qe.b = 1;
            qe.c = -6;
            //delta  < 0
            qe.calcDeltaZeros(qe.a, qe.b, qe.c);
            Assert.Equal(qe.x1, -3);
            Assert.False(qe.x2 != 2);

        }
    }
}
