using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlow_framwork
{
    [Binding]
    public sealed class TextureConfig
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void CalledFirstInFeature() {
            Console.WriteLine("Do this first in Feature");
        }
        [BeforeScenario]
        public static void CalledBeforeScenario()
        {
            Console.WriteLine("Do this first in CalledBeforeScenario");
        }
        [BeforeScenarioBlock]
        public static void CalledBeforeScenarioBlock()
        {
            Console.WriteLine("Do this first in CalledBeforeScenarioBlock");
        }

        [BeforeStep]
        public static void CalledBeforeStep()
        {
            Console.WriteLine("Do this first in CalledBeforeStep");
        }
        [BeforeTestRun]
        public static void CalledBeforeTestRun()
        {
            Console.WriteLine("Do this first in CalledBeforeTestRun");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Do this first in BeforeScenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Do this first in AfterScenario");
        }
    }
}
