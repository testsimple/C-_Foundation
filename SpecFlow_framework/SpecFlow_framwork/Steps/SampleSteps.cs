using System;
using TechTalk.SpecFlow;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow.Assist;

namespace SpecFlow_framwork.Steps
{
    [Binding]
    public class SampleSteps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            Console.WriteLine(number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Press Add Key");
        }

        [When(@"I want to see")]
        public void WhenIWantToSee(Table table)
        {
            //var detail = table.CreateSet<Student>();
            //foreach (var sv in detail) {
            //    Console.WriteLine(sv.Name);
            //    Console.WriteLine(sv.Age);
            //    Console.WriteLine(sv.BVC);
            //}

            // Using dynamic
            var detail = table.CreateDynamicSet();
            foreach (var p in detail) {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.BVC);
            }

        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int number)
        {
            Console.WriteLine("Shoud see {0}", number);
        }
    }
}
