using OpenQA.Selenium;

namespace FluxDayMobileAutomation.PageObjects
{
    public class MainMenuPageObject
    {
        private const string MAIN_MENU_LINK_CSS = "body > div.fixed > nav > ul > li.toggle-topbar.menu-icon > a";
        private const string TOB_BAR_CLASS = "top-bar expanded fixed";
        private const string ADD_TASK_CSS = "body > div:nth-child(1) > nav > section > ul.right > li > a";
        private const string MY_TASKS_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(1) > a";
        private const string DEPARTMENTS_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(2) > a";
        private const string TEAM_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(3) > a";
        private const string USERS_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(4) > a";
        private const string OKR_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(5) > a";
        private const string REPORTS_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(6) > a";
        private const string OAUTH_APPLICATIONS_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(7) > a";
        private const string MANAGER_NAME_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(8) > a";
        private const string EMPLOYEE_NAME_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(7) > a";
        private const string MANAGER_LOGOUT_CSS = "body > div:nth-child(1) > nav > section > ul.right > div > li:nth-child(9) > a";
        private const string EMPLOYEE_LOGOUT_CSS = "/html/body/div[1]/nav/section/ul[1]/div/li[8]/a";

        private IWebDriver driver;

        public MainMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement MainMenu
        {
            get
            {
                return driver.FindElement(By.CssSelector(MAIN_MENU_LINK_CSS));
            }

        }

        public IWebElement AddTask
        {
            get
            {
                return driver.FindElement(By.CssSelector(ADD_TASK_CSS));
            }
        }

        public IWebElement MyTasks
        {
            get
            {
                return driver.FindElement(By.CssSelector(MY_TASKS_CSS));
            }
        }

        public IWebElement DepartmentsItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(DEPARTMENTS_CSS));
            }
        }

        public IWebElement TeamItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(TEAM_CSS));
            }
        }

        public IWebElement UsersItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(USERS_CSS));
            }
        }

        public IWebElement OKRItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(OKR_CSS));
            }
        }

        public IWebElement ReportsItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(REPORTS_CSS));
            }
        }

        public IWebElement OauthApplicationItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(OAUTH_APPLICATIONS_CSS));
            }
        }

        public IWebElement ManagerNameItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(MANAGER_NAME_CSS));
            }
        }

        public IWebElement EmployeeNameItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(EMPLOYEE_NAME_CSS));
            }
        }

        public IWebElement ManagerLogoutItem
        {
            get
            {
                return driver.FindElement(By.CssSelector(MANAGER_LOGOUT_CSS));
            }
        }

        public IWebElement EmployeeLogoutItem
        {
            get
            {
                return driver.FindElement(By.XPath(EMPLOYEE_LOGOUT_CSS));
            }
        }
    }
}
