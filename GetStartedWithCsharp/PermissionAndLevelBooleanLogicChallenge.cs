using FluentAssertions;

namespace GetStartedWithCsharp;

internal class PermissionAndLevel
{
    internal static string CreateWelcomeMessage(string permission, int level) =>
        permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user."
        : permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user."
        : permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access."
        : permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges."
        : "You do not have sufficient privileges.";
}

public class PermissionAndLevelTests
{
    [Theory]
    [InlineData("Admin", 60, "Welcome, Super Admin user.")]
    [InlineData("Admin", 55, "Welcome, Admin user.")]
    [InlineData("Manager", 20, "Contact an Admin for access.")]
    [InlineData("User|Manager", 55, "Contact an Admin for access.")]
    [InlineData("Manager", 19, "You do not have sufficient privileges.")]
    [InlineData("Admin|Manager", 60, "Welcome, Super Admin user.")]
    [InlineData("Admin|Manager", 55, "Welcome, Admin user.")]
    [InlineData("User", 10, "You do not have sufficient privileges.")]
    [InlineData("Guest", 1, "You do not have sufficient privileges.")]
    public void VerifyPermissionAndLevelFor(string permission, int level, string expectedMessage)
    {
        string actualMessage = PermissionAndLevel.CreateWelcomeMessage(permission, level);

        actualMessage.Should().Be(expectedMessage);
    }
}
