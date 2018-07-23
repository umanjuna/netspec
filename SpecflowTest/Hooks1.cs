﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SpecflowTest.Pages;

namespace SpecflowTest
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            WebdriverManager.InitialiseWebdriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebdriverManager.webDriver.Dispose();
        }
    }
}
