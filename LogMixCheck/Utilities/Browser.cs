using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogMixCheck.Configuration;

namespace LogMixCheck.Utilities
{
    public class Browser
    {
        public static void GoToUrl(string url)
        {
            SeleniumExecutor.Driver().Navigate().GoToUrl(url);
        }
    }
}
