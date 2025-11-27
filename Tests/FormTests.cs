using NUnit.Framework;
using OpenQA.Selenium;
using CloudQA.AutomationTests.Drivers;
using CloudQA.AutomationTests.Pages;

namespace CloudQA.AutomationTests.Tests
{
    public class FormTests
    {
        private IWebDriver _driver;
        private AutomationPracticeFormPage _formPage;

        [SetUp]
        public void Setup()
        {
            _driver = WebDriverFactory.CreateDriver();
            _driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            _formPage = new AutomationPracticeFormPage(_driver);
        }

        [Test]
        public void EnterFirstName_ShouldTypeCorrectly()
        {
            _formPage.EnterFirstName("Ayushman");
            Assert.AreEqual("Ayushman", _formPage.GetFirstNameValue());
        }

        [Test]
        public void EnterEmail_ShouldTypeCorrectly()
        {
            _formPage.EnterEmail("test@example.com");
            Assert.AreEqual("test@example.com", _formPage.GetEmailValue());
        }

        [Test]
        public void SelectMaleGender_ShouldBeSelected()
        {
            _formPage.SelectGender("Male");
            Assert.IsTrue(_formPage.IsGenderSelected("Male"));
        }
        [Test]
        public void SelectFemaleGender_ShouldBeSelected()
        {
            _formPage.SelectGender("Female");
            Assert.IsTrue(_formPage.IsGenderSelected("Female"));
        }
        [Test]
        public void SelectTransGender_ShouldBeSelected()
        {
            _formPage.SelectGender("Transgender");
            Assert.IsTrue(_formPage.IsGenderSelected("Transgender"));
        }


        [TearDown]
        public void Cleanup()
        {
            _driver.Quit();
        }
    }
}
