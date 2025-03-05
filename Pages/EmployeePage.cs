using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalWeek3And4.Pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Created");
        }

        public void EditEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Edited");
        }

        public void DeleteEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Deleted");
        }

        public string GetElementText(IWebDriver driver, string columnName)
        {
            IWebElement webElement;
            if (columnName.Equals(""))
            {
                webElement = driver.FindElement(By.XPath(""));
            }
            else if (columnName.Equals(""))
            {
                webElement = driver.FindElement(By.XPath(""));
            }
            else
            {
                webElement = driver.FindElement(By.XPath(""));
            }
            return webElement.Text;
        }
    }
}
