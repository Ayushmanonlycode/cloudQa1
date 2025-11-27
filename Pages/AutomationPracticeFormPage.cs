using OpenQA.Selenium;

namespace CloudQA.AutomationTests.Pages
{
    public class AutomationPracticeFormPage
    {
        private readonly IWebDriver _driver;

        public AutomationPracticeFormPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement InputByLabel(string labelText) =>
            _driver.FindElement(By.XPath($"//label[contains(text(), '{labelText}')]/following::input[1]"));

        private IWebElement ClickableByText(string text) =>
            _driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));

        public void EnterFirstName(string name)
        {
            InputByLabel("First Name").SendKeys(name);
        }

        public void EnterEmail(string email)
        {
            InputByLabel("Email").SendKeys(email);
        }

        public void SelectGender(string gender)
        {
            var radioButton = _driver.FindElement(By.XPath(
                $"//input[@type='radio' and @value='{gender}']"
            ));
            radioButton.Click();
        }




        public string GetFirstNameValue() =>
            InputByLabel("First Name").GetAttribute("value");

        public string GetEmailValue() =>
            InputByLabel("Email").GetAttribute("value");

        public bool IsGenderSelected(string gender)
        {
            var radioButton = _driver.FindElement(By.XPath(
                $"//input[@type='radio' and @value='{gender}']"
            ));
            return radioButton.Selected;
        }




    }
}
