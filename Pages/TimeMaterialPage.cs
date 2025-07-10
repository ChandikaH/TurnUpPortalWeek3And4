using OpenQA.Selenium;

namespace TurnUpPortalWeek3And4.Pages
{
    public class TimeMaterialPage : BasePage
    {
        private By CreateNewButton => By.XPath("//a[contains(text(),'Create New')]");
        private By CodeField => By.Id("Code");
        private By DescriptionField => By.Id("Description");
        private By PriceField => By.XPath("//input[@class='k-formatted-value k-input']");
        private By SaveButton => By.XPath("//input[@value='Save']");
        private By LastRecordEditButton => By.XPath("(//a[contains(text(),'Edit')])[last()]");
        private By LastRecordDeleteButton => By.XPath("(//a[contains(text(),'Delete')])[last()]");
        private By ConfirmDeleteButton => By.XPath("//button[text()='Delete']");
        private By LastRecordDescription => By.XPath("(//table//tbody//tr)[last()]/td[3]");

        public void CreateTimeRecord(string code, string description, string price)
        {
            Click(CreateNewButton);
            Type(CodeField, code);
            Type(DescriptionField, description);
            Type(PriceField, price);
            Click(SaveButton);
        }

        public void EditLastTimeRecord(string newDescription)
        {
            Click(LastRecordEditButton);
            Type(DescriptionField, newDescription);
            Click(SaveButton);
        }

        public void DeleteLastTimeRecord()
        {
            Click(LastRecordDeleteButton);
            Click(ConfirmDeleteButton);
        }

        public string GetLastRecordDescription()
        {
            return GetText(LastRecordDescription);
        }
    }
}