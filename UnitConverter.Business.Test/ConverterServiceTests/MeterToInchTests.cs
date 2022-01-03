using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public class MeterToInchTests
    {
        private readonly ConverterService _converterService;

        public MeterToInchTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(1, 39.37008)]
        [InlineData(0.3, 11.811024)]
        [InlineData(0, 0)]
        private void Should_CalculateCorrectly(double input, double expected)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.MeterToInch(input);

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
