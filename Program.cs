using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

class CloudQATest
{
    static void Main(string[] args)
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--start-maximized");

        IWebDriver driver = new ChromeDriver(options);

        try
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("automationtestform")));

        //  automatically test any three fields

        //First name
            var firstName = driver.FindElement(By.Id("fname"));
            firstName.SendKeys("Arun");

           // Gender
            var genderMale = driver.FindElement(By.Id("male"));
            genderMale.Click();

        // mobile no.
            var mobile = driver.FindElement(By.Id("mobile"));
            mobile.SendKeys("9876543210");

            Console.WriteLine("✅ Form filled successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("❌ Error: " + ex.Message);
        }
        finally
        {
            System.Threading.Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
