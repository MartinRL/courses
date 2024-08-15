using FluentAssertions;

namespace GetStartedWithCsharp;

public class FizzBuzz
{
    internal static IEnumerable<string> Generate(int count)
    {
        static string fizzBuzzText(int n)
        {
            if ((n % 3) == 0 && (n % 5) == 0)
                return $"{n} - FizzBuzz";
            else if ((n % 3) == 0)
                return $"{n} - Fizz";
            else if ((n % 5) == 0)
                return $"{n} - Buzz";
            else 
                return n.ToString();
        };

        return Enumerable.Range(1, count).Select(fizzBuzzText);
    }
}

public class FizzBuzzTests
{
    [Fact]
    public void GenerateFizzBuzz_ShouldReturnExpectedSequence()
    {
        // Arrange
        var expected = new List<string>
        {
            "1",
            "2",
            "3 - Fizz",
            "4",
            "5 - Buzz",
            "6 - Fizz",
            "7",
            "8",
            "9 - Fizz",
            "10 - Buzz",
            "11",
            "12 - Fizz",
            "13",
            "14",
            "15 - FizzBuzz",
            "16",
            "17",
            "18 - Fizz",
            "19",
            "20 - Buzz",
            "21 - Fizz"
        };

        // Act
        var result = FizzBuzz.Generate(21);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}
