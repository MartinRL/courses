using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace GetStartedWithCsharp.Tests
{
    public class ProgramTests
    {
        [Fact]
        public async Task VerifyConsoleOutput()
        {
            // Capture the console output
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Call the main method of the console application
                Program.Main(args: null);

                var output = sw.ToString().Trim();

                // Verify the output using Verify.Xunit
                await Verify(output);
            }
        }
    }
}
