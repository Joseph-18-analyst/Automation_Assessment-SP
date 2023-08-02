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
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace automationtechnical_aseessment
{
    class Program
    {
     

        [Test]
  public static void Main()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                
                driver.Navigate().GoToUrl("https://www.spanishpoint.ie/");
                Thread.Sleep(15000);
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
                driver.Manage().Window.Maximize();
                Thread.Sleep(5000);
                // Expand 'Solutions & Services' and select 'Modern Work'
                IWebElement solutionsServices = driver.FindElement(By.Id("menu-item-30711"));

                solutionsServices.Click();
                Thread.Sleep(5000);
                IWebElement modernWork = driver.FindElement(By.XPath("//div[@class='menu-main-menu-container']//li[@id='menu-item-30711']//li[@id='menu-item-23119']"));
                Thread.Sleep(5000);
                modernWork.Click();
              
                IWebElement cookiepolicyaccept = driver.FindElement(By.XPath("//div[@class='cli-wrapper']//a[2]"));
                Thread.Sleep(4000);
                cookiepolicyaccept.Click();
                Thread.Sleep(4000);


                // Under the 'Modern Workplace Solutions' header, click the 'Content & Collaboration' tab
                IWebElement contentCollaboration = driver.FindElement(By.XPath("//div[@class='vc_tta-container']//div//div[@class='vc_tta-tabs-container']//ul//li[2]"));
                 Thread.Sleep(3000);
                 contentCollaboration.Click(); Thread.Sleep(3000);



                // Wait for the 'Content & Collaboration' panel to load
                WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));



                // Assert that there is a header with the text 'Content & Collaboration' and verify the paragraph text
                IWebElement headerElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60))
               .Until(ExpectedConditions.ElementIsVisible(By.XPath("//h3[text() = 'Content & Collaboration']")));
             
                
                WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                
                string headerText = headerElement.Text;
                Thread.Sleep(3000);
                Console.WriteLine(headerText);

                
                IWebElement paragraphElement = driver.FindElement(By.XPath("//h3[text() = 'Content & Collaboration']/following::div[1]//p"));
               
                string paragraphText = paragraphElement.Text;
                
                
                Assert.IsTrue(headerElement.Text.Contains("Content & Collaboration"), "Header text matches the expected value.");
                 Assert.AreEqual(headerText, "Content & Collaboration");
                string expectedStartText = "Spanish Point customers tell us that people are their most important asset";
                   Assert.IsTrue(paragraphText.StartsWith(expectedStartText), "Paragraph text starts with the expected value.");
                Console.WriteLine(paragraphText);
                Thread.Sleep(10000);
                WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
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
    

