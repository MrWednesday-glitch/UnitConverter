using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.ConverterServiceTests
{
    public class InchToMeterTests
    {
        private readonly ConverterService _converterService;

        public InchToMeterTests()
        {
            _converterService = new ConverterService();
        }

        [Theory]
        [InlineData(40, 1.015999967488001)] //TODO find a way to cap the decimals at a certain place or something
        [InlineData(2.25, 0.057149998171200055)]
        [InlineData(0, 0)]
        [InlineData(-40, 1.015999967488001)]
        public void Should_CalculateCorrectly(double input, double expected)
        {
            // -- Arrange


            // -- Act
            double actual = _converterService.InchToMeter(input);

            // -- Assert
            Assert.Equal(expected, actual);
        }
    }
}
