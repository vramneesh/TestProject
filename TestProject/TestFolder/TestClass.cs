using LightBDD.Framework;
using LightBDD.NUnit3;
using FluentAssertions;
using LightBDD.Framework.Scenarios;
using NUnit.Framework;

namespace TestProject.TestFolder
{
    [FeatureDescription("Test Class")]
    public class TestClass : BaseClass
    {
        [Scenario]
        public void TestMethod1()
        {
            Runner.RunScenario(TestContextMethond1);
        }

        [Scenario]
        public void TestMethod2()
        {
            Runner.RunScenario(TestContextMethond2);
        }

        public void TestContextMethond1()
        {
            Assert.AreEqual(4, 2 + 2);
        }

        public void TestContextMethond2()
        {
            Assert.AreEqual(4, 2 + 3);
        }
    }
}
