using OpenQA.Selenium;

namespace LogMixCheck.Configuration
{
    public class SeleniumExecutor
    {
        private static AsyncLocal<IWebDriver> webDriver = new AsyncLocal<IWebDriver>();

        public static IWebDriver Driver(DriverOptions? driverOptions = null)
        {
            return webDriver.Value ?? Initialize(driverOptions);
        }

        public static IWebDriver Initialize(DriverOptions? driverOptions = null)
        {
            webDriver.Value = WebDriverFactory.InitializeDriver(driverOptions);
            return webDriver.Value;
        }
    }
}
