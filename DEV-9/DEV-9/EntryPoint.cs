﻿using OpenQA.Selenium.Chrome;
namespace DEV_9
{
    /// <summary>
    /// Calls all methods for all tested web pages
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            ChromeDriver driver = new ChromeDriver();
            var logInPage = new LogInPage(driver, "YourEmail", "YourPassword");
            logInPage.LogIn();
            var messagePage = new MessagesPage(driver);
            messagePage.ShowUnreadMessages();
            driver.Close();
            driver.Quit();
        }
    }
}