using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using SpecFlow.Assist.Dynamic;

namespace SpecFlow_framwork.Steps
{
    [Binding]
    public class Specflow_Outline_ExampleSteps
    {
        [Given(@"I have new page")]
        public void GivenIHaveNewPage()
        {
            Console.WriteLine("---New page");
        }
        
        [Given(@"I add (.*), (.*), (.*) into new feature")]
        public void GivenIAddDungGHNIntoNewFeature(string n, int a, string m)
        {
            Console.WriteLine("---Display {0}", n);
            Console.WriteLine("---Display {0}", a);
            Console.WriteLine("---Display {0}", m);
        }
        
        [Then(@"New feature created")]
        public void ThenNewFeatureCreated()
        {
            //ScenarioContext.Current.Pending();
            Console.WriteLine("---Page created");
            ScenarioContext.Current["InforStep"] = "OutLine Passed !!!";

            Console.WriteLine(ScenarioContext.Current["InforStep"].ToString());
            Console.WriteLine("Count: " + ScenarioContext.Current.Count);
            Console.WriteLine("SceInfo:" + ScenarioContext.Current.ScenarioInfo);
            Console.WriteLine("SceInfo.Tag:" + ScenarioContext.Current.ScenarioInfo.Tags);
            Console.WriteLine("SceInfo.Title:" + ScenarioContext.Current.ScenarioInfo.Title);

            //
            List<Student> svDetail = new List<Student>() {
                new Student() {
                    Age = 13,
                    Name = "Hoang",
                    BVC = "GHF"
                },
                new Student() {
                    Age = 13,
                    Name = "Hoang",
                    BVC = "GHF"
                }
            //
            };

            // Save the value of scenario
            ScenarioContext.Current.Add("SV_detail", svDetail);

            // Get to use
            var svContext = ScenarioContext.Current.Get<IEnumerable<Student>>("SV_detail");

            foreach (var p in svContext) {
                Console.WriteLine("Age: {0}", p.Age);
                Console.WriteLine("BVC: {0}", p.BVC);
                Console.WriteLine("Name: {0}", p.Name);
            }
        }
    }
}
