﻿using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowFirst.Steps
{

    [Binding]
    class GoogleSearchSteps
    {

        IWebDriver currentDriver = null;

        [Given(@"I have navigated to Google page")]
        public void GivenIHaveNavigatedToGooglePage()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);
            currentDriver = Browser.Current;
        }

        [Given(@"I see the Google page fully loaded")]
        public void GivenISeeTheGooglePageFullyLoaded()
        {
            if (currentDriver.FindElement(By.Name("q")).Displayed == true)
                Console.WriteLine("Page loaded fully");
            else
                Console.WriteLine("Page failed to load");
        }

        [When(@"I type search keyword as")]
        public void WhenITypeSearchKeywordAs(Table table)
        {
            dynamic tableDetail = table.CreateDynamicInstance();
            string key = tableDetail.Keyword;
            if (currentDriver.FindElement(By.PartialLinkText(key)).Displayed == true)
                Console.WriteLine("Control exists");
            else
                Console.WriteLine("Control does not exist");
        }
    }
}
