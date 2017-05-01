using System;
using Xunit;

namespace BugHunter.xUnit
{
    public class BugHunterTests
    {
        [Theory]
        [InlineData(false,true)]
        [InlineData(true,false)]
        public void TestBugCanDodge(bool didDodge, bool shouldBeDead)
        {
            var bug = new Bug();
            var rayGun = new Raygun();

            if (didDodge)
            {
                bug.Dodge();
            }

            rayGun.FireAt(bug);

            if (shouldBeDead)
            {
                Assert.True(bug.IsDead());
            }
            else { Assert.False(bug.IsDead()); }
        }
    }
}
