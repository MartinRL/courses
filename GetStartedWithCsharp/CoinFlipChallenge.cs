
using System;

namespace GetStartedWithCsharp;

public static class CoinFlipper
{
    internal static string Flip() => new Random().Next(2) == 0 ? "heads" : "tails";
}

public class CoinFlipTest
{
    [Fact]
    public void VerifyThatCoinFlipIsEvenlyDistributed()
    {
        // Arrange
        const int numberOfFlips = 10000;
        int headsCount = 0;
        int tailsCount = 0;

        // Act
        for (int i = 0; i < numberOfFlips; i++)
        {
            string result = CoinFlipper.Flip();
            if (result == "heads")
            {
                headsCount++;
            }
            else if (result == "tails")
            {
                tailsCount++;
            }
        }

        // Assert
        // We expect roughly 50% of the results to be heads and 50% tails.
        double headsPercentage = (double)headsCount / numberOfFlips * 100;
        double tailsPercentage = (double)tailsCount / numberOfFlips * 100;

        Assert.True(headsPercentage > 49 && headsPercentage < 51, $"Heads percentage was {headsPercentage}, which is outside the expected range.");
        Assert.True(tailsPercentage > 49 && tailsPercentage < 51, $"Tails percentage was {tailsPercentage}, which is outside the expected range.");
    }
}
