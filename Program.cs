using OpenQA.Selenium; //input to access selenium
using OpenQA.Selenium.Chrome;//input  to open website using code

namespace E4SeleniumTraining
{
    internal class Program
    {
        static void Main(string[] args)
    {
        WebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(2000); //it will wait for 2sec before reading the next line
        driver.FindElement(By.LinkText("REGISTER"));

            String pageTitle = driver.Title;
            Console.WriteLine("Page title is\t" + pageTitle);
            
        

    }//end main
    }//end class
}//end namespace
