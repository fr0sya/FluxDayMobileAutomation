using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using FluxDayMobileAutomation.PageObjects;

namespace Appium
{
    [TestFixture()]
    public class LoginUIMobailTest
    {
        private const string LOGOUT_TEXT = "Logout";
        private IWebDriver driver;
        private TimeSpan implicitTimeoutSec = TimeSpan.FromSeconds(10);

        [SetUp]
        public void BeforeAll()
        {
            //Set the capabilities
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.BrowserName, "Chrome");
            capabilities.SetCapability(MobileCapabilityType.PlatformName, "Android");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "7.1.1");
            capabilities.SetCapability(MobileCapabilityType.AutomationName, "UIAutomator2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "cool_c1");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://localhost:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            driver.Manage().Timeouts().ImplicitlyWait(implicitTimeoutSec);
            driver.Url = "https://app.fluxday.io/users/sign_in";
        }

        [TearDown]
        public void AfterAll()
        {
            driver.Quit();
        }

        [Test]
        [TestCase("admin@fluxday.io", "password", "Admin User")]
        [TestCase("emp1@fluxday.io", "password", "Employee 1")]
        public void LoginTest(string email, string password, string userName)
        {
            var login = new LoginPageObject(driver);
            var mainManuPageObject = new MainMenuPageObject(driver);

            // user email
            login.UserEmailTextBox.Click();
            login.UserEmailTextBox.Clear();
            login.UserEmailTextBox.SendKeys(email);

            // user password
            login.UserPasswordTextBox.Click();
            login.UserPasswordTextBox.Clear();
            login.UserPasswordTextBox.SendKeys(password);

            // press button
            login.LoginButton.Click();

            // open/click on main manu
            mainManuPageObject.MainMenu.Click();

            // check the expected result
            if (userName == "Admin User")
            {
                Assert.AreEqual(userName, mainManuPageObject.ManagerNameItem.Text);
                Assert.AreEqual(LOGOUT_TEXT, mainManuPageObject.ManagerLogoutItem.Text);
            }
            else
            {
                Assert.AreEqual(userName, mainManuPageObject.EmployeeNameItem.Text);
                Assert.AreEqual(LOGOUT_TEXT, mainManuPageObject.EmployeeLogoutItem.Text);
            }
        }
    }
}
