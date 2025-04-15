using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnUpPortalWeek3And4.Pages
{
    class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            Console.WriteLine("Creating Employee Record");
        }

        public void EditEmployee(IWebDriver driver)
        {
            Console.WriteLine("Editing Employee Record");
        }

        public void DeleteEmployee(IWebDriver driver)
        {
            Console.WriteLine("Deleting Employee Record");
        }
    }
}
