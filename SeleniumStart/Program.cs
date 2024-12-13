// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, Selenium!");


ChromeDriver driver = new ChromeDriver();
driver.Url = "http://way2automation.com";
Console.WriteLine(driver.Title);
Debug.WriteLine(driver.Title);
driver.Close();
driver.Quit();