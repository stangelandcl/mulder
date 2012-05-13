// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Mulder.Acceptance.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("user compiles site")]
    public partial class UserCompilesSiteFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        #line 1 "UserCompilesSite.feature"
        #line hidden
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "user compiles site", "In order to serve my site with my favorite web server\nAs a user\nI want to compile my site into a static web site", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("compile default site")]
        public virtual void CompileDefaultSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("compile default site", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I have just created a new mulder powered site");
#line 8
 testRunner.And("I have changed directories into the new mulder powered site");
#line 9
 testRunner.When("I run the compile command");
#line 10
 testRunner.Then("I should see \"Loading site data...\" message");
#line 11
 testRunner.And("I should see \"Compiling site...\" message");
#line 12
 testRunner.And("I should see \"create [time] public/index.html\" message");
#line 13
 testRunner.And("I should see \"create [time] public/style.css\" message");
#line 14
 testRunner.And("I should see \"Site compiled in [time]s.\"");
#line 15
 testRunner.And("I should see configured output directory created");
#line 16
 testRunner.And("the configured output directory should be named \"public\"");
#line 17
 testRunner.And("I should see created files in configured output directory");
#line 18
 testRunner.And("the \"public/index.html\" file should contain the default home content");
#line 19
 testRunner.And("the \"public/style.css\" file should contain the default styles");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion