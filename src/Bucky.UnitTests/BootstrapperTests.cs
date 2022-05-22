using Avalonia.Controls.ApplicationLifetimes;
using NSubstitute;
using Shouldly;
using Xunit;

namespace Bucky.UnitTests;

public class BootstrapperTests
{
    [Fact]
    public void ContainerIsValid()
    {
        var desktop = Substitute.For<IClassicDesktopStyleApplicationLifetime>();
        using var container = Bootstrapper.CreateContainer(desktop);

        Should.NotThrow(() => container.AssertConfigurationIsValid());
    }
}