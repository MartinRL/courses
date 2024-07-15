using System;
using Xunit;
using FluentAssertions;

namespace GetStartedWithCsharp.Tests
{
    public class TempFormatter
    {
        private const int fahrenheit = 94;

        public string CelsiusMsg = $"The temperature is {((decimal)(fahrenheit - 32) * 5 / 9):N1} Celsius.";
    }

    public class Tests
    {
        [Fact]
        public void VerifyCelsiusMsg() => new TempFormatter().CelsiusMsg.Should().Be("The temperature is 34.4 Celsius.");
    }
}
