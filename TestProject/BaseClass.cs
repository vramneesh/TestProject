using LightBDD.NUnit3;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Configuration;
using System.IO;

namespace TestProject
{
    [AllureNUnit]
    public class BaseClass : FeatureFixture
    {
        [OneTimeSetUp]
        public void OnTimeSetup()
        {
            
            var Setup = ConfigurationManager.AppSettings["env"];
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }
    }
}
