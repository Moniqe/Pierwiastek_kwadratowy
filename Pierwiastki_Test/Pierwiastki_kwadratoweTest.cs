using Pierwiastek_kwadratowy;
using System;
using Xunit;

namespace Pierwiastek_kwadratowy.Test
{
    public class Równanie_kwadratoweTest
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

        
    }
}