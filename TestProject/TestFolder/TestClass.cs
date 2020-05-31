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
        public void TestMethod()
        {
            Runner.RunScenario(TestContextMethond);
        }

        public void TestContextMethond()
        {
            Assert.AreEqual(4, 2 + 2);
        }
    }
}
