using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public class CentimeterToMeterTests
    {
        private readonly ConverterService _converterService;

        public CentimeterToMeterTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(100, 1)]
        [InlineData(5.36, 0.0536)]
        [InlineData(0, 0)]
        public void Should_CalculateCorrectly(double input, double expected)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.CentimeterToMeter(input);

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
