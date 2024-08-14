using FluentAssertions;

namespace GetStartedWithCsharp;

internal class PermissionAndLevel
{
    internal static string CreateWelcomeMessage(string permission, int level) => throw new NotImplementedException();
}

public class PermissionAndLevelTests
{
    [Theory]
    [InlineData("Admin", 60, "Welcome, Super Admin user.")]
    [InlineData("Admin", 55, "Welcome, Admin user.")]
    [InlineData("Manager", 25, "Contact an Admin for access.")]
    [InlineData("Manager", 19, "You do not have sufficient privileges.")]
    [InlineData("User", 30, "You do not have sufficient privileges.")]
    [InlineData("Admin", 40, "Welcome, Admin user.")]
    [InlineData("Manager", 20, "Contact an Admin for access.")]
    [InlineData("Manager", 5, "You do not have sufficient privileges.")]
    public void VerifyPermissionAndLevelFor(string permission, int level, string expectedMessage)
    {
        string actualMessage = PermissionAndLevel.CreateWelcomeMessage(permission, level);

        actualMessage.Should().Be(expectedMessage);
    }
}
