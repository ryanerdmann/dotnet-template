using Xunit;

namespace Project.Library.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
        var library = new Library("Test");
        Assert.Equal("Test", library.Name);
    }
}