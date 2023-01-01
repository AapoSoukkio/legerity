namespace Legerity.Web.Tests.Tests;

using System.Collections.Generic;
using System.IO;
using System;
using Helpers;
using OpenQA.Selenium.Remote;
using Pages;

[TestFixtureSource(nameof(PlatformOptions))]
public class ButtonTests : BaseTestClass
{
    private const string WebApplication = "https://www.w3schools.com/tags/tryit.asp?filename=tryhtml_button_test";

    public ButtonTests(AppManagerOptions options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets the platform options to run tests on.
    /// </summary>
    protected static IEnumerable<AppManagerOptions> PlatformOptions => new List<AppManagerOptions>
    {
        new WebAppManagerOptions(
            WebAppDriverType.Chrome,
            Path.Combine(Environment.CurrentDirectory))
        {
            Maximize = true, Url = WebApplication, ImplicitWait = ImplicitWait, DriverOptions = ConfigureChromeOptions()
        }
    };

    [Test]
    public void ShouldLocateButton()
    {
        // Arrange
        RemoteWebDriver app = this.StartApp(this.Options, WaitUntilConditions.TitleContains("W3Schools"), ImplicitWait);

        var buttonPage = new ButtonPage(app);
        buttonPage.AcceptCookies<ButtonPage>();

        // Act
        buttonPage.SwitchToContentFrame<ButtonPage>();

        // Assert
        Assert.IsTrue(buttonPage.Button.IsVisible);
    }
}