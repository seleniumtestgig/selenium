﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
namespace seleniumtest
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver();
			driver.Navigate().GoToUrl("http://plumb5.io/");


		}
	}
}
