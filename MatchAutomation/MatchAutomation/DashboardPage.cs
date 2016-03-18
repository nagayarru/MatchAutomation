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
                var subscribebtn = Driver.Instance.FindElements(By.ClassName("btnSubscribe"));
                
                    return subscribebtn[0].Text == "Subscribe";
                
            
            }
        }
    }
}
