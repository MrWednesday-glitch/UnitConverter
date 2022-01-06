using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public class CentimeterToMillimeterTests
    {
        private readonly ConverterService _converterService;

        public CentimeterToMillimeterTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(1, 10)]
        [InlineData(0.05, 0.5)]
        [InlineData(0, 0)]
        [InlineData(-5, 50)]
        private void Should_CalculateCorrectly(double input, double expected)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.CentimeterToMillimeter(input);

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
