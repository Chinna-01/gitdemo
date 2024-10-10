﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace gitdemo.Web.AcceptanceTests.Features;

using System;
using System.Linq;
using TechTalk.SpecFlow;


[System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
[System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
[NUnit.Framework.TestFixtureAttribute()]
[NUnit.Framework.DescriptionAttribute("Login")]
[NUnit.Framework.CategoryAttribute("Login")]
public partial class LoginFeature
{

    private TechTalk.SpecFlow.ITestRunner testRunner;

    private static string[] featureTags = new string[] {
            "Login"};

#line 1 "Login.feature"
#line hidden

    [NUnit.Framework.OneTimeSetUpAttribute()]
    public virtual void FeatureSetup()
    {
        testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
        TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Login", "    User can log in", ProgrammingLanguage.CSharp, featureTags);
        testRunner.OnFeatureStart(featureInfo);
    }

    [NUnit.Framework.OneTimeTearDownAttribute()]
    public virtual void FeatureTearDown()
    {
        testRunner.OnFeatureEnd();
        testRunner = null;
    }

    [NUnit.Framework.SetUpAttribute()]
    public void TestInitialize()
    {
    }

    [NUnit.Framework.TearDownAttribute()]
    public void TestTearDown()
    {
        testRunner.OnScenarioEnd();
    }

    public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
    {
        testRunner.OnScenarioInitialize(scenarioInfo);
        testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
    }

    public void ScenarioStart()
    {
        testRunner.OnScenarioStart();
    }

    public void ScenarioCleanup()
    {
        testRunner.CollectScenarioErrors();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("User can log in with valid credentials")]
    public void UserCanLogInWithValidCredentials()
    {
        string[] tagsOfScenario = ((string[])(null));
        System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can log in with valid credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 6
            testRunner.Given("a logged out user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
            testRunner.When("the user logs in with valid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
            testRunner.Then("they log in successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }

    [NUnit.Framework.TestAttribute()]
    [NUnit.Framework.DescriptionAttribute("User cannot log in with invalid credentials")]
    public void UserCannotLogInWithInvalidCredentials()
    {
        string[] tagsOfScenario = ((string[])(null));
        System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
        TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User cannot log in with invalid credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 10
        this.ScenarioInitialize(scenarioInfo);
#line hidden
        if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
        {
            testRunner.SkipScenario();
        }
        else
        {
            this.ScenarioStart();
#line 11
            testRunner.Given("a logged out user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
            testRunner.When("the user logs in with invalid credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
            testRunner.Then("an error is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        this.ScenarioCleanup();
    }
}
#pragma warning restore
#endregion
