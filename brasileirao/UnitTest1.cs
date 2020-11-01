using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System;

namespace brasileirao
{
    [TestClass]
    public class UnitTest1
    {
        connection con = new connection();
        private static IWebDriver driver;
        private static string baseURL;

        [ClassInitialize]
        public static void InicializarClass(TestContext testContext)
        {
            var option = new ChromeOptions()
            {
                BinaryLocation = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
            };
            driver = new ChromeDriver(option);
            baseURL = "https://www.google.com/";
        }

        [TestMethod]
        public void TestMethod1()
        {
            string sql;
            MySqlCommand cmd;
            con.OpenConn();

            driver.Navigate().GoToUrl("https://globoesporte.globo.com/futebol/brasileirao-serie-a/");
            var elemtTable = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[1]"));
         
            List<IWebElement> lstTable1 = new List<IWebElement>(elemtTable.FindElements(By.TagName("tr")));

           for (int i = 1; i < lstTable1.Count; i++)
            {
               var classific = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table/tbody/tr[" + i + "]/td[1]"));
               var time = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table/tbody/tr[" + i + "]/td[2]"));

               var pontos = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr["+i+"]/td[1]"));
               var jogos = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[2]"));
               var vitorias = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[3]"));
               var empates = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[4]"));
               var derrotas = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[5]"));
               var gp = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[6]"));
               var gc = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[7]"));
               var sg = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[8]"));
               var porcent = driver.FindElement(By.XPath("//section[@id='classificacao__wrapper']/article/section/div/table[2]/tbody/tr[" + i + "]/td[9]"));

                sql = "INSERT INTO tabela VALUES(@classific, @time, @pontos, @jogos, @vitorias, @empates, @derrotas, @gp, @gc, @sg, @porcent)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@classific", classific.Text);
                cmd.Parameters.AddWithValue("@time", time.Text);

                cmd.Parameters.AddWithValue("@pontos", pontos.Text);
                cmd.Parameters.AddWithValue("@jogos", jogos.Text);
                cmd.Parameters.AddWithValue("@vitorias", vitorias.Text);
                cmd.Parameters.AddWithValue("@empates", empates.Text);
                cmd.Parameters.AddWithValue("@derrotas", derrotas.Text);
                cmd.Parameters.AddWithValue("@gp", gp.Text);
                cmd.Parameters.AddWithValue("@gc", gc.Text);
                cmd.Parameters.AddWithValue("@sg",sg.Text);
                cmd.Parameters.AddWithValue("@porcent", porcent.Text);

                cmd.ExecuteNonQuery();

                Console.WriteLine(classific.Text + "\t\t" + time.Text);
            }
            driver.Quit();
        }
    }
}
