using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FirefoxProfile profile = new FirefoxProfile(@"C:\Users\saotr\AppData\Roaming\Mozilla\Firefox\Profiles\m227mqpt.thuy");
            FirefoxOptions options = new FirefoxOptions();
            options.Profile = profile;

            FirefoxDriver driver = new FirefoxDriver(options);
            driver.Url = "https://www.instagram.com/huongthu2801/";
            driver.Navigate();
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector("#react-root > section > main > div > div._2z6nI > article > div:nth-child(1) > div > div:nth-child(1) > div:nth-child(1) > a > div > div._9AhH0")).Click();
            for (int i = 0; i < 53; i++)
            {
                //html.js.logged-in.client-root.js-focus-visible.sDN5V body div._2dDPU.CkGkG div.zZYga div.PdwC2.fXiEu.s2MYR article.M9sTE.L_LMM.JyscU.ePUX4 div.eo2As section.ltpMr.Slqrh span.fr66n button.wpO6b div.QBdPU span svg._8-yf5
                driver.FindElement(By.CssSelector("html.js.logged-in.client-root.js-focus-visible.sDN5V body div._2dDPU.CkGkG div.zZYga div.PdwC2.fXiEu.s2MYR article.M9sTE.L_LMM.JyscU.ePUX4 div.eo2As section.ltpMr.Slqrh span.fr66n button.wpO6b div.QBdPU span svg._8-yf5")).Click();
                driver.FindElement(By.LinkText("Tiếp")).Click();
                Thread.Sleep(5000);
            }
            MessageBox.Show("Xong rồi nè");

        }
    }
}
