using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitConverter.Business.Test.LoggingServiceTests
{
    public class WriteToLogfileTests
    {
        private readonly LoggingService _logging;

        public WriteToLogfileTests()
        {
            _logging = new LoggingService();
        }

        [Fact]
        public void Should_WriteExpectedOutput()
        {

        }
        //I still don't really understand mocking so I am not sure how to test this
    }
}
