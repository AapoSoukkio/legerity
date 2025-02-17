namespace Legerity.WinUI.Tests.Pages;

using Legerity.Windows;
using Legerity.Windows.Elements.WinUI;
using OpenQA.Selenium.Remote;

internal class InfoBarPage : BaseNavigationPage
{
    public InfoBarPage(RemoteWebDriver app) : base(app)
    {
    }

    public InfoBar CloseableInfoBar => this.FindElement(WindowsByExtras.AutomationId("TestInfoBar1"));

    public InfoBarPage CloseClosableInfoBar()
    {
        this.CloseableInfoBar.Close();
        return this;
    }
}