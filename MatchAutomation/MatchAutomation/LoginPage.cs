using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace MatchAutomation
{
    public class LoginPage
    {
        public static void GoTo()
        {
            Driver.Instance.Navigate().GoToUrl("http://www.match.com");
            
        }

        public static LoginCommand LoginAs(string userName)
        {
            return new LoginCommand(userName);
        }

        public static SignUpCommand LoginAsNewUser(string newEmail)
        {
            return new SignUpCommand(newEmail);
        }
    
    }

    public class SignUpCommand
    {
        private readonly string newEmail;
        private string password;

        public SignUpCommand(string newEmail)
        {
            this.newEmail = newEmail;
        }


        public SignUpCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void SignUp()

        {


            
            new SelectElement(Driver.Instance.FindElement(By.Name("gc"))).SelectByText("Man");
            Driver.Instance.FindElement(By.CssSelector("option[value=\"1\"]")).Click();

            new SelectElement(Driver.Instance.FindElement(By.Name("tr"))).SelectByText("Woman");
            Driver.Instance.FindElement(By.CssSelector("select[name=\"tr\"] > option[value=\"2\"]")).Click();
            new SelectElement(Driver.Instance.FindElement(By.Name("lage"))).SelectByText("20");
            Driver.Instance.FindElement(By.CssSelector("option[value=\"20\"]")).Click();
            new SelectElement(Driver.Instance.FindElement(By.Name("uage"))).SelectByText("30");
            Driver.Instance.FindElement(By.CssSelector("select[name=\"uage\"] > option[value=\"30\"]")).Click();
            Driver.Instance.FindElement(By.Name("pc")).Clear();
            Driver.Instance.FindElement(By.Name("pc")).SendKeys("78641");
            Driver.Instance.FindElement(By.CssSelector("button.button.button-primary")).Click();

            var email = Driver.Instance.FindElement(By.Name("email"));
                email.Clear();
            email.SendKeys(newEmail);

            var choosepassword = Driver.Instance.FindElement(By.Name("password"));
            choosepassword.Clear();
            choosepassword.SendKeys(password);

            
            new SelectElement(Driver.Instance.FindElement(By.Id("birthMonth"))).SelectByText("Mar");
            Driver.Instance.FindElement(By.CssSelector("#birthMonth > option[value=\"3\"]")).Click();
            new SelectElement(Driver.Instance.FindElement(By.Id("birthDay"))).SelectByText("3");
            Driver.Instance.FindElement(By.CssSelector("#birthDay > option[value=\"3\"]")).Click();
            new SelectElement(Driver.Instance.FindElement(By.Id("birthYear"))).SelectByText("1987");
            Driver.Instance.FindElement(By.CssSelector("option[value=\"1987\"]")).Click();
            Driver.Instance.FindElement(By.XPath("//button[@type='submit']")).Click();
            Driver.Instance.FindElement(By.Id("usr")).Clear();
            Driver.Instance.FindElement(By.Id("usr")).SendKeys("Nick");
            Driver.Instance.FindElement(By.XPath("(//button[@type='submit'])[2]")).Click();
            Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
           
            if ( Driver.Instance.FindElement(By.Id("password")).Displayed)
            {
                var password1 = Driver.Instance.FindElement(By.Id("password"));
                password1.SendKeys("password");

                
               // IWebDriver.sendKeys.Click();
            }
            else
            {
                Driver.Instance.FindElement(By.ClassName("button button - primary progress - next buttonnoCss")).Click();
            }
           

            Driver.Instance.FindElement(By.XPath("//button[@type='submit']")).Click();
            Driver.Instance.FindElement(By.Name("Next")).Click();

            for (int i = 1; i <= 12; i++)
            {
                var keepGoingButton = Driver.Instance.FindElement(By.PartialLinkText("keep going"));
                Driver.Instance.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
                keepGoingButton.Click();

            }

            Driver.Instance.FindElement(By.Id("SelfEssay_Text")).Click();
            Driver.Instance.FindElement(By.Id("SelfEssay_Text")).Clear();
            Driver.Instance.FindElement(By.Id("SelfEssay_Text")).SendKeys("sdfsadflnsdfklsdlkfkkkkdsfasdfsadfsdfsafsdfskdfskdvskdvksdvksdvnslaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaanllllllllllllllllllllllllllllllllllllllsdfffffffffffffffffffffffffffffffffflkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk");
            Driver.Instance.FindElement(By.LinkText("keep going »")).Click();
            Driver.Instance.FindElement(By.Name("Next")).Click();
            Driver.Instance.FindElement(By.Name("Next")).Click();
            Driver.Instance.FindElement(By.LinkText("Next Step »")).Click();
            Driver.Instance.FindElement(By.Id("ctl00_matchHeader_ctl00_PrimaryNavigationRepeater1_ctl05_Repeater1_ctl06_HyperLink4")).Click();
            Driver.Instance.FindElement(By.XPath("//img[contains(@src,'http://sthumbnails.match.com/sthumbnails/62/41/250126241Z.jpeg')]")).Click();
            Driver.Instance.FindElement(By.LinkText("F FAVORITE HER")).Click();
            Driver.Instance.FindElement(By.Id("ctl00_matchHeader_ctl00_PrimaryNavigationRepeater1_ctl09_Repeater1_ctl03_HyperLink4")).Click();

        }
    }

    public class LoginCommand
    {
        private string password;
        private readonly string userName;
        

        public LoginCommand(string userName)
        {
            this.userName = userName;
        }
     

 
        public LoginCommand WithPassword(string password)
        {
            this.password = password;
            return this;
        }

        public void Login()

        {
            var memberSignin = Driver.Instance.FindElement(By.LinkText("Member Sign In »"));
              memberSignin.Click();
            var emailIdInput = Driver.Instance.FindElement(By.Id("email"));
                emailIdInput.Clear();
            emailIdInput.SendKeys(userName);

            var passwordInput = Driver.Instance.FindElement(By.Id("password"));
            passwordInput.Clear();
            passwordInput.SendKeys(password);

            var loginButton = Driver.Instance.FindElement(By.XPath("//button[@type='submit']"));
            loginButton.Click();

         

              
        }
    }
}
