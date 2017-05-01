using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace BugHunter.xUnit
{
    [Binding]
    public class BugBlasterSteps
    {
        private Raygun _raygun;
        private Bug _bug;

        [Given(@"I have a raygun")]
        public void GivenIHaveARaygun()
        {
            _raygun = new Raygun();
        }
        
        [Given(@"I have at least (.*) charge")]
        public void GivenIHaveAtLeastCharge(int p0)
        {
            _raygun.Recharge();
        }
        
        [Given(@"I have a stationary target bug")]
        public void GivenIHaveAStationaryTargetBug()
        {
            _bug = new Bug();
        }
        
        [When(@"I fire at the bug")]
        public void WhenIFireAtTheBug()
        {
            _raygun.FireAt(_bug);
        }
        
        [Then(@"the result should be a dead bug")]
        public void ThenTheResultShouldBeADeadBug()
        {
            _bug.IsDead.Should().BeTrue();
        }
    }
}
