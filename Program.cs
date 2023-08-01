using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using System.Threading;


namespace automationtechnical_aseessment
{
    class Program
    {
       [Test]
  public static void Main()
        {
            IWebDriver driver = new ChromeDriver("C:\\chrome-win64\\chrome-win64");

            try
            {
                // Visit https://www.spanishpoint.ie/
                driver.Navigate().GoToUrl("https://www.spanishpoint.ie/");
                Thread.Sleep(15000);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                driver.Manage().Window.Maximize();
                Thread.Sleep(15000);
                IWebElement solutionsServices = driver.FindElement(By.Id("menu-item-30711"));

                solutionsServices.Click();
                Thread.Sleep(5000);
                IWebElement modernWork = driver.FindElement(By.XPath("//div[@class='menu-main-menu-container']//li[@id='menu-item-30711']//li[@id='menu-item-23119']"));
                Thread.Sleep(3000);
                modernWork.Click();
                Thread.Sleep(20000);
                IWebElement cookiepolicyaccept = driver.FindElement(By.XPath("//div[@class='cli-wrapper']//a[2]"));
                Thread.Sleep(7000);
                cookiepolicyaccept.Click();
                 // IWebElement contentCollaboration = driver.FindElement(By.XPath("//div[@class='vc_tta-tabs-container']//ul[@class='vc_tta - tabs - list']//li[@id='menu-item-23119']"));
                 IWebElement contentCollaboration = driver.FindElement(By.XPath("//div[@class='vc_tta-container']//div//div[@class='vc_tta-tabs-container']//ul//li[2]"));
                  Thread.Sleep(3000);
                  contentCollaboration.Click();

                 // Wait for the 'Content & Collaboration' panel to load
                 WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                Thread.Sleep(10000);
                //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='TAB_82']")));

                // Assert that there is a header with the text 'Content & Collaboration' and verify the paragraph text
                IWebElement headerElement = driver.FindElement(By.XPath("//h3[contains(text(), 'Content & Collaboration')]"));
                Thread.Sleep(10000);
               // IWebElement paragraphElement = driver.FindElement(By.XPath("//h3[contains(text(), 'Content & Collaboration')]/following-sibling::p"));
                //IWebElement paragraphElement = driver.FindElement(By.CssSelector("div.wpb_text_column wpb_content_element wpb_animate_when_almost_visible wpb_fadeIn fadeIn wpb_start_animation animated + p"));
                string headerText = headerElement.Text;
               // string paragraphText = paragraphElement.Text;
                
                Console.WriteLine(headerText);
                //Assert.IsTrue(headerElement.Text.Contains("Content & Collaboration"), "Header text matches the expected value.");
                //  Assert.AreEqual(headerText, "Content & Collaboration");
                //string expectedStartText = "Spanish Point customers tell us that people are their most important asset";
                //   Assert.IsTrue(paragraphText.StartsWith(expectedStartText), "Paragraph text starts with the expected value.");
                //Console.WriteLine(paragraphText);
                Thread.Sleep(10000);
                if (headerText.Contains("Content & Collaboration"))
                {
                    Console.WriteLine("Test passed!");
                }
                else
                {
                    Console.WriteLine("Test failed!");
                }

            }
            finally
            {
            
                // Close the browser
                         driver.Quit();
                    }


            }
        }
    }
    

