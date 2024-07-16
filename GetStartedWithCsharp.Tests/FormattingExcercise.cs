using System;
using static System.Globalization.CultureInfo;
using FluentAssertions;

namespace GetStartedWithCsharp
{
    public class TempearureFormatter
    {
        private const int fahrenheit = 94;

        public string CelsiusMsg = string.Create(CreateSpecificCulture("en-US"), $"The temperature is {((decimal)(fahrenheit - 32) * 5 / 9):N1} Celsius.");
    }

    public class TempearureFormatterTests
    {
        [Fact]
        public void VerifyCelsiusMsg() => new TempearureFormatter().CelsiusMsg.Should().Be("The temperature is 34.4 Celsius.");
    }
}
