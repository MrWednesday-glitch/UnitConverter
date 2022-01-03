using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Business;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public  class MeterToCentimeterTests
    {
        private readonly ConverterService _converterService;

        public MeterToCentimeterTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(1, 100)]
        [InlineData(50, 5000)]
        [InlineData(0, 0)]
        public void Should_CalculateCorrectly(double input, double output)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.MeterToCentimeter(input);

            // -- Assert
            Assert.Equal(output, actual);
        }
    }
}
