using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ADD
using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;
using System.IO;
using System.Diagnostics;
using OpenQA.Selenium.Remote;

namespace Selenium_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            //IWebDriver driver = new InternetExplorerDriver();
            //IWebDriver driver = new EdgeDriver("c:\users\dung lam\documents\visual studio 2015\Projects\Selenium_01\Selenium_01\MicrosoftWebDriver.exe",);

            //driver.Navigate().GoToUrl("http://tuoitre.vn");

            //string serverPath = "MicrosoftWebDriver.exe";
            //serverPath = Path.Combine(System.Environment.ExpandEnvironmentVariables("c:\\users\\dung lam\\documents\\visual studio 2015\\Projects\\Selenium_01\\Selenium_01"), serverPath);
            //EdgeOptions options = new EdgeOptions();
            //options.PageLoadStrategy = EdgePageLoadStrategy.Eager;
            //IWebDriver driver = new EdgeDriver(serverPath, options);

            //IWebDriver driver = new EdgeDriver(@"c:\users\dung lam\documents\visual studio 2015\Projects\Selenium_01\Selenium_01");
            //driver.Url = "http://tuoitre.vn";

            //OpenQA.Selenium.Remote.DesiredCapabilities capabilities = DesiredCapabilities.Firefox();
            //capabilities.SetCapability("marionette", true);
            //var driver = new RemoteWebDriver(capabilities);

            //var driver = new FirefoxDriver(new FirefoxOptions());

            //FirefoxProfile profile = new FirefoxProfile();
            //var service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Dung Lam\Documents\visual studio 2015\Projects\Selenium_01\Selenium_01\bin\Debug", "geckodriver.exe");
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //var option = new FirefoxOptions(profile) { IsMarionette = true };
            //var driver = new FirefoxDriver(
            //    service,
            //    option,
            //    TimeSpan.FromSeconds(30));


            //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Users\Dung Lam\Documents\visual studio 2015\Projects\Selenium_01\Selenium_01\bin\Debug", "geckodriver.exe");
            //service.Port = 64444;
            //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //var driver = new FirefoxDriver(service);

            var driverService = FirefoxDriverService.CreateDefaultService();
            driverService.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driverService.HideCommandPromptWindow = true;
            driverService.SuppressInitialDiagnosticInformation = true;

            var driver = new FirefoxDriver(driverService, new FirefoxOptions(), TimeSpan.FromSeconds(60));

            //IWebDriver driver = new FirefoxDriver(option1);
            driver.Navigate().GoToUrl("http://tuoitre.vn");

            //Process.Start("microsoft-edge:http://tuoitre.vn");

        }
    }
}
