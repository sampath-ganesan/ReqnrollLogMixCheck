using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace LogMixCheck.Configuration
{
    public class WebDriverFactory
    {
        public static IWebDriver InitializeDriver(DriverOptions driverOptions = null)
        {
            var edgeOptions = new EdgeOptions
            {
                UnhandledPromptBehavior = UnhandledPromptBehavior.Dismiss,
                AcceptInsecureCertificates = true,
                PageLoadStrategy = PageLoadStrategy.Normal,
            };

            edgeOptions.AddArgument("--start-maximized");

            string edgePath = string.Empty;

            if (File.Exists(Path.Combine(Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName, "msedgedriver.exe")))
            {
                edgePath = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            }
            else
            {
                var driverPath = new DriverFinder(driverOptions);
                edgePath = driverPath.GetDriverPath();
            }

            var edgeService = EdgeDriverService.CreateDefaultService(edgePath);

            return new EdgeDriver(edgeService, edgeOptions);
        }
    }
}
