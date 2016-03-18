using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace MatchAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                var chatOption = Driver.Instance.FindElements(By.Id("hdr-chat"));

                if (chatOption.Count > 0)
                return chatOption[0].Text == "C Chat";
              return false;
                
            
            }
        }
    }
}
