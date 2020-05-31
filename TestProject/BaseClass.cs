using LightBDD.NUnit3;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Configuration;

namespace TestProject
{
    [AllureNUnit]
    public class BaseClass : FeatureFixture
    {
        [OneTimeSetUp]
        public void OnTimeSetup()
        {
            var Setup = ConfigurationManager.AppSettings["env"];
        }
    }
}
