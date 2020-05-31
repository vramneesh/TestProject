using LightBDD.Framework;
using LightBDD.NUnit3;
using FluentAssertions;
using LightBDD.Framework.Scenarios;
using NUnit.Framework;
using Allure.Commons;
using System;

namespace TestProject.TestFolder
{
    [FeatureDescription("Test Class")]
    public class TestClass : BaseClass
    {
        [Label("LABEL1")]
        [Scenario]
        public void TestMethod1()
        {
            Runner.RunScenario(TestContextMethond1);
        }

        [Label("LABEL2")]
        [Scenario]
        public void TestMethod2()
        {
            Runner.RunScenario(TestContextMethond2);
        }

        [Label("LABEL3")]
        [Scenario]
        public void TestMethod3()
        {
            Runner.RunScenario(TestContextMethond3);
        }

        public void TestContextMethond1()
        {
            Console.WriteLine("TEST WRITING");
            Assert.AreEqual(4, 2 + 2);
        }

        public void TestContextMethond2()
        {
            Assert.AreEqual(4, 2 + 3);
        }

        public void TestContextMethond3()
        {
            Assert.AreEqual(4, 2 + 3);
        }
    }
}
