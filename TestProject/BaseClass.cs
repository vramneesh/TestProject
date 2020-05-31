using LightBDD.NUnit3;
using NUnit.Framework;
using System.Configuration;

namespace TestProject
{
    public class BaseClass : FeatureFixture
    {
        [OneTimeSetUp]
        public void OnTimeSetup()
        {
            var Setup = ConfigurationManager.AppSettings["env"];
        }
    }
}
