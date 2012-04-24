﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.Countdown
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class OrderItemsReservationScenariosToVerifyTheCountdownManagementAndMetrics_Feature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Countdown.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Order Items Reservation scenarios to verify the countdown management and metrics." +
                    "", "In order to reserve selected Order Items, they will be held for an arbitary amoun" +
                    "t of time \r\nso the Registrant may complete the Order for the selected Order Item" +
                    "s", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Order Items Reservation scenarios to verify the countdown management and metrics." +
                            "")))
            {
                Conference.Specflow.Features.Registration.Countdown.OrderItemsReservationScenariosToVerifyTheCountdownManagementAndMetrics_Feature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199"});
            table1.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "$500"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50"});
#line 6
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "1"});
            table2.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 11
 testRunner.And("the selected Order Items", ((string)(null)), table2);
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Make a reservation with the selected Order Items")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Order Items Reservation scenarios to verify the countdown management and metrics." +
            "")]
        public virtual void MakeAReservationWithTheSelectedOrderItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Make a reservation with the selected Order Items", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 19
 testRunner.When("the Registrant proceed to make the Reservation");
#line 20
 testRunner.Then("the Reservation is confirmed for all the selected Order Items");
#line 21
 testRunner.And("the total should read $249");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "1"});
            table3.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table3.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 22
 testRunner.And("the countdown started for these Order Items", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("All Seat Types are available, one get reserved and two get waitlisted")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Order Items Reservation scenarios to verify the countdown management and metrics." +
            "")]
        public virtual void AllSeatTypesAreAvailableOneGetReservedAndTwoGetWaitlisted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All Seat Types are available, one get reserved and two get waitlisted", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type"});
            table4.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young"});
            table4.AddRow(new string[] {
                        "Additional cocktail party"});
#line 32
 testRunner.Given("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table4);
#line 36
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 37
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table5);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table6.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 41
 testRunner.And("These other Order Items get reserved", ((string)(null)), table6);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table7.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 44
 testRunner.And("the countdown started for these Order Items", ((string)(null)), table7);
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("The Registrant exceed the allowed time when offered to be waitlisted and has 1 Or" +
            "der Items reserved")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Order Items Reservation scenarios to verify the countdown management and metrics." +
            "")]
        public virtual void TheRegistrantExceedTheAllowedTimeWhenOfferedToBeWaitlistedAndHas1OrderItemsReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The Registrant exceed the allowed time when offered to be waitlisted and has 1 Or" +
                    "der Items reserved", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table8.AddRow(new string[] {
                        "Pre-con Workshop with Greg Young",
                        "1"});
            table8.AddRow(new string[] {
                        "Additional cocktail party",
                        "1"});
#line 50
 testRunner.Given("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table8);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table9.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 54
 testRunner.And("These other Order Items get reserved", ((string)(null)), table9);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table10.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 57
 testRunner.And("the countdown started for these Order Items", ((string)(null)), table10);
#line 60
 testRunner.When("the time to confirm the reservation has exceeded the countdown");
#line 61
 testRunner.Then("the Reservation is cancelled and a message should be shown regarding the expired " +
                    "countdown");
#line 62
 testRunner.And("the Registrant should be offered to start over the Reservation with the available" +
                    " seats");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
