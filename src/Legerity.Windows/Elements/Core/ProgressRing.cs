namespace Legerity.Windows.Elements.Core;

using Legerity.Windows.Extensions;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

/// <summary>
/// Defines a <see cref="WindowsElement"/> wrapper for the core UWP ProgressRing control.
/// </summary>
public class ProgressRing : WindowsElementWrapper
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProgressRing"/> class.
    /// </summary>
    /// <param name="element">
    /// The <see cref="WindowsElement"/> reference.
    /// </param>
    public ProgressRing(WindowsElement element)
        : base(element)
    {
    }

    /// <summary>
    /// Gets the value of the progress ring.
    /// </summary>
    /// <exception cref="StaleElementReferenceException">Thrown when an element is no longer valid in the document DOM.</exception>
    public virtual double Percentage => this.GetRangeValue();

    /// <summary>
    /// Gets a value indicating whether the control is in an indeterminate state.
    /// </summary>
    /// <exception cref="StaleElementReferenceException">Thrown when an element is no longer valid in the document DOM.</exception>
    public bool IsIndeterminate =>
        this.GetAttribute("IsRangeValuePatternAvailable").Equals(
            "False",
            StringComparison.CurrentCultureIgnoreCase);

    /// <summary>
    /// Allows conversion of a <see cref="WindowsElement"/> to the <see cref="ProgressRing"/> without direct casting.
    /// </summary>
    /// <param name="element">
    /// The <see cref="WindowsElement"/>.
    /// </param>
    /// <returns>
    /// The <see cref="ProgressRing"/>.
    /// </returns>
    public static implicit operator ProgressRing(WindowsElement element)
    {
        return new ProgressRing(element);
    }

    /// <summary>
    /// Allows conversion of a <see cref="AppiumWebElement"/> to the <see cref="ProgressRing"/> without direct casting.
    /// </summary>
    /// <param name="element">
    /// The <see cref="AppiumWebElement"/>.
    /// </param>
    /// <returns>
    /// The <see cref="ProgressRing"/>.
    /// </returns>
    public static implicit operator ProgressRing(AppiumWebElement element)
    {
        return new ProgressRing(element as WindowsElement);
    }

    /// <summary>
    /// Allows conversion of a <see cref="RemoteWebElement"/> to the <see cref="ProgressRing"/> without direct casting.
    /// </summary>
    /// <param name="element">
    /// The <see cref="RemoteWebElement"/>.
    /// </param>
    /// <returns>
    /// The <see cref="ProgressRing"/>.
    /// </returns>
    public static implicit operator ProgressRing(RemoteWebElement element)
    {
        return new ProgressRing(element as WindowsElement);
    }
}