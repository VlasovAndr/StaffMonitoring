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
namespace SpecFlowProject.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EmployersLibraryFeature : object, Xunit.IClassFixture<EmployersLibraryFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "EmployersLibrary.feature"
#line hidden
        
        public EmployersLibraryFeature(EmployersLibraryFeature.FixtureData fixtureData, SpecFlowProject_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "EmployersLibrary", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line hidden
#line 4
 testRunner.Given("I create company with name \'FLS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "LastName",
                        "FirstName",
                        "ID"});
            table1.AddRow(new string[] {
                        "Vlasov",
                        "Alexei",
                        "IdOfPerson1"});
            table1.AddRow(new string[] {
                        "Vlasov",
                        "Andrei",
                        "IdOfPerson2"});
            table1.AddRow(new string[] {
                        "Ivlev",
                        "Andrei",
                        "IdOfPerson3"});
            table1.AddRow(new string[] {
                        "Filipov",
                        "Vladimir",
                        "IdOfPerson4"});
#line 5
 testRunner.And("I add persons to the company with name \'FLS\'", ((string)(null)), table1, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetStuffOfficeEmployers_WhenAllPersonInOffice")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetStuffOfficeEmployers_WhenAllPersonInOffice")]
        [Xunit.TraitAttribute("Category", "Alex")]
        public virtual void GetStuffOfficeEmployers_WhenAllPersonInOffice()
        {
            string[] tagsOfScenario = new string[] {
                    "Alex"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetStuffOfficeEmployers_WhenAllPersonInOffice", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 14
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When("I Get List Of Stuff Office Employers as new Director of company \'FLS\' and put it " +
                        "in expected scenario context \'stuffOfficeEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table2.AddRow(new string[] {
                            "IdOfPerson1"});
                table2.AddRow(new string[] {
                            "IdOfPerson2"});
                table2.AddRow(new string[] {
                            "IdOfPerson3"});
                table2.AddRow(new string[] {
                            "IdOfPerson4"});
#line 17
 testRunner.And("I validate collection of \'allCompanyEmployers\' \'FLS\' company consist of person wi" +
                        "th id", ((string)(null)), table2, "And ");
#line hidden
#line 23
 testRunner.And("I validate count of \'stuffOfficeEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table3.AddRow(new string[] {
                            "IdOfPerson1"});
                table3.AddRow(new string[] {
                            "IdOfPerson2"});
                table3.AddRow(new string[] {
                            "IdOfPerson3"});
                table3.AddRow(new string[] {
                            "IdOfPerson4"});
#line 24
 testRunner.And("I validate collection of \'stuffOfficeEmployers\' \'FLS\' company consist of person w" +
                        "ith id", ((string)(null)), table3, "And ");
#line hidden
#line 30
 testRunner.And("I validate that collection of \'stuffOfficeEmployers\' does not contain absent pers" +
                        "ons", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetStuffOfficeEmployers_WhenNobodyPersonInOffice")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetStuffOfficeEmployers_WhenNobodyPersonInOffice")]
        [Xunit.TraitAttribute("Category", "Alex")]
        public virtual void GetStuffOfficeEmployers_WhenNobodyPersonInOffice()
        {
            string[] tagsOfScenario = new string[] {
                    "Alex"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetStuffOfficeEmployers_WhenNobodyPersonInOffice", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 33
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 34
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.When("I Get List Of Nobody Stuff Office Employers as new Director of company \'FLS\' and " +
                        "put it in expected scenario context \'NobodyOfficeEmployersInOffice\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And("I validate collection of all office employers \'allCompanyEmployers\' consist of pe" +
                        "rson with last name \'Vlasov\', \'Vlasov\', \'Ivlev\', \'Filipov\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("I validate count of Nobody stuff office employers collection \'NobodyOfficeEmploye" +
                        "rsInOffice\' is \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("I validate collection of office employers \'NobodyOfficeEmployersInOffice\' is empt" +
                        "y", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetStuffOfficeEmployers_WhenOnePersonComeOut")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetStuffOfficeEmployers_WhenOnePersonComeOut")]
        [Xunit.TraitAttribute("Category", "Alex")]
        public virtual void GetStuffOfficeEmployers_WhenOnePersonComeOut()
        {
            string[] tagsOfScenario = new string[] {
                    "Alex"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetStuffOfficeEmployers_WhenOnePersonComeOut", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 42
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 43
 testRunner.When("The person with LastName \'Ivlev\' and FirstName \'Andrei\' come out from the office " +
                        "company \'FLS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.When("I Get List Of Stuff Office Employers as new Director of company \'FLS\' and put it " +
                        "in expected scenario context \'stuffOfficeEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.And("I validate collection of all office employers \'allCompanyEmployers\' consist of pe" +
                        "rson with last name \'Vlasov\', \'Vlasov\', \'Ivlev\', \'Filipov\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("I validate collection of office employers \'stuffOfficeEmployers\' consist of perso" +
                        "n with last name \'Vlasov\', \'Vlasov\', \'Filipov\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Then("I validate count of office employers collection \'stuffOfficeEmployers\' is \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetAbsentOfficeEmployers_WhenAllPersonInOffice")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetAbsentOfficeEmployers_WhenAllPersonInOffice")]
        [Xunit.TraitAttribute("Category", "Andrew")]
        public virtual void GetAbsentOfficeEmployers_WhenAllPersonInOffice()
        {
            string[] tagsOfScenario = new string[] {
                    "Andrew"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetAbsentOfficeEmployers_WhenAllPersonInOffice", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 54
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.When("I Get List Of Absent Office Employers as new Director of company \'FLS\' and put it" +
                        " in expected scenario context \'absentOfficeEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table4.AddRow(new string[] {
                            "IdOfPerson1"});
                table4.AddRow(new string[] {
                            "IdOfPerson2"});
                table4.AddRow(new string[] {
                            "IdOfPerson3"});
                table4.AddRow(new string[] {
                            "IdOfPerson4"});
#line 57
 testRunner.And("I validate collection of \'allCompanyEmployers\' \'FLS\' company consist of person wi" +
                        "th id", ((string)(null)), table4, "And ");
#line hidden
#line 63
 testRunner.And("I validate count of \'absentOfficeEmployers\' collection is \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("I validate collection of absent office employers \'absentOfficeEmployers\' is empty" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetAbsentOfficeEmployers_WhenOnePersonComeOut")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetAbsentOfficeEmployers_WhenOnePersonComeOut")]
        [Xunit.TraitAttribute("Category", "Andrew")]
        public virtual void GetAbsentOfficeEmployers_WhenOnePersonComeOut()
        {
            string[] tagsOfScenario = new string[] {
                    "Andrew"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetAbsentOfficeEmployers_WhenOnePersonComeOut", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 67
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table5.AddRow(new string[] {
                            "IdOfPerson4"});
#line 68
 testRunner.When("The person with id come out from the office company \'FLS\'", ((string)(null)), table5, "When ");
#line hidden
#line 71
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.When("I Get List Of Absent Office Employers as new Director of company \'FLS\' and put it" +
                        " in expected scenario context \'absentOfficeEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table6.AddRow(new string[] {
                            "IdOfPerson1"});
                table6.AddRow(new string[] {
                            "IdOfPerson2"});
                table6.AddRow(new string[] {
                            "IdOfPerson3"});
                table6.AddRow(new string[] {
                            "IdOfPerson4"});
#line 74
 testRunner.And("I validate collection of \'allCompanyEmployers\' \'FLS\' company consist of person wi" +
                        "th id", ((string)(null)), table6, "And ");
#line hidden
#line 80
 testRunner.And("I validate count of \'absentOfficeEmployers\' collection is \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table7.AddRow(new string[] {
                            "IdOfPerson4"});
#line 81
 testRunner.And("I validate collection of \'absentOfficeEmployers\' \'FLS\' company consist of person " +
                        "with id", ((string)(null)), table7, "And ");
#line hidden
#line 84
 testRunner.And("I validate that collection of absent office employers \'absentOfficeEmployers\' doe" +
                        "s not contain persons in office", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="GetAbsentOfficeEmployers_WhenAllPersonComeOutAndOneComeIn")]
        [Xunit.TraitAttribute("FeatureTitle", "EmployersLibrary")]
        [Xunit.TraitAttribute("Description", "GetAbsentOfficeEmployers_WhenAllPersonComeOutAndOneComeIn")]
        [Xunit.TraitAttribute("Category", "Andrew")]
        public virtual void GetAbsentOfficeEmployers_WhenAllPersonComeOutAndOneComeIn()
        {
            string[] tagsOfScenario = new string[] {
                    "Andrew"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GetAbsentOfficeEmployers_WhenAllPersonComeOutAndOneComeIn", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 87
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 3
this.FeatureBackground();
#line hidden
#line 88
 testRunner.When("All person come out from the office company \'FLS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.When("The person with LastName \'Ivlev\' and FirstName \'Andrei\' come in from the office c" +
                        "ompany \'FLS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table8.AddRow(new string[] {
                            "IdOfPerson3"});
#line 90
 testRunner.When("The person with id come in from the office company \'FLS\'", ((string)(null)), table8, "When ");
#line hidden
#line 93
 testRunner.When("I Get List Of All Company Employers as new Director of company \'FLS\' and put it i" +
                        "n actual scenario context \'allCompanyEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 94
 testRunner.When("I Get List Of Absent Office Employers as new Director of company \'FLS\' and put it" +
                        " in expected scenario context \'absentOfficeEmployers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("I validate count of \'allCompanyEmployers\' collection is \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table9.AddRow(new string[] {
                            "IdOfPerson1"});
                table9.AddRow(new string[] {
                            "IdOfPerson2"});
                table9.AddRow(new string[] {
                            "IdOfPerson3"});
                table9.AddRow(new string[] {
                            "IdOfPerson4"});
#line 96
 testRunner.And("I validate collection of \'allCompanyEmployers\' \'FLS\' company consist of person wi" +
                        "th id", ((string)(null)), table9, "And ");
#line hidden
#line 102
 testRunner.And("I validate count of \'absentOfficeEmployers\' collection is \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "ID"});
                table10.AddRow(new string[] {
                            "IdOfPerson1"});
                table10.AddRow(new string[] {
                            "IdOfPerson2"});
                table10.AddRow(new string[] {
                            "IdOfPerson4"});
#line 103
 testRunner.And("I validate collection of \'absentOfficeEmployers\' \'FLS\' company consist of person " +
                        "with id", ((string)(null)), table10, "And ");
#line hidden
#line 108
 testRunner.And("I validate that collection of absent office employers \'absentOfficeEmployers\' doe" +
                        "s not contain persons in office", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                EmployersLibraryFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                EmployersLibraryFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
