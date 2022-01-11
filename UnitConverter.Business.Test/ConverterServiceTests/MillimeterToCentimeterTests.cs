using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public class MillimeterToCentimeterTests
    {
        private readonly ConverterService _converterService;

        public MillimeterToCentimeterTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(10, 1)]
        [InlineData(0.3, 0.03)]
        [InlineData(0, 0)]
        private void Should_CalculateCorrectly(double input, double expected)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.MillimeterToCentimeter(input);

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
