using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using NUnit.Framework;
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Interfaces;
    using OpenQA.Selenium.Appium.MultiTouch;
    using OpenQA.Selenium.Interactions;
    using OpenQA.Selenium.Remote;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Appium.Enums;

    class Program
    {
        static void Main(string[] args)
        {
            AppiumDriver<IWebElement> driver;
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "CB5A22X9J0");
            //capabilities.SetCapability(MobileCapabilityType.DeviceName, "0915f92996d50f05");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion,"6.0.1");
            capabilities.SetCapability(MobileCapabilityType.BrowserName, "Chrome");

            //capabilities.SetCapability("platformVersion", "6.0.1");
            //capabilities.SetCapability("device", "Android");
            //capabilities.SetCapability("deviceName", "0915f92996d50f05");
            //capabilities.SetCapability("platformName", "Android");
            //capabilities.SetCapability("browserName", "chrome"); //com.android.chrome

            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));// RemoteWebDriver

            driver.Navigate().GoToUrl("http://tuoitre.vn");
            Console.WriteLine("----------");
        }
    }
}
