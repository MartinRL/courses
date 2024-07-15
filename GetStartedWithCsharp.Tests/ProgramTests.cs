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
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                Program.Main();

                var output = sw.ToString().Trim();

                await Verify(output);
            }
        }
    }
}
