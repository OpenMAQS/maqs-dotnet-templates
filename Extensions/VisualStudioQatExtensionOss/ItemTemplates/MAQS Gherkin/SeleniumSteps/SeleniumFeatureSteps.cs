﻿using OpenMAQS.Maqs.SpecFlow.TestSteps;
using TechTalk.SpecFlow;

namespace $rootnamespace$
{
    /// <summary>
    /// Steps class for $safeitemname$
    /// To utilize MAQS features for the steps in this class, make sure at add a 'MAQS_Selenium' tag to the feature file(s)
    /// </summary>
    [Binding]
    public class $safeitemname$ : BaseSeleniumTestSteps
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="$safeitemname$"/> class.
        /// </summary>
        /// <param name="context">The scenario context.</param>
        protected $safeitemname$(ScenarioContext context) : base(context)
        {
        }

		/// <summary>
        /// Sample given method
        /// </summary>
        [Given(@"condition")]
        public void GivenCondition()
        {
            this.LocalScenarioContext.Pending();
        }
        
        /// <summary>
        /// Sample when method
        /// </summary>
        [When(@"action")]
        public void WhenAction()
        {
            this.LocalScenarioContext.Pending();
        }
        
        /// <summary>
        /// Sample then method
        /// </summary>
        [Then(@"verification")]
        public void ThenVerification()
        {
            this.LocalScenarioContext.Pending();
        }
    }
}
