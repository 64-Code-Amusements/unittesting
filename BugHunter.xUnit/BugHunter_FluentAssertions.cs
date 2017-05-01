using Xunit;
using FluentAssertions;

namespace BugHunter.xUnit
{
    public class BugHunter_FluentAssertions
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void FireMultipleTimes(int fireCount)
        {

            Bug bug = new Bug();
            Raygun gun = new Raygun();

            for (int i = 0; i < fireCount; i++)
            {
                gun.FireAt(bug);
            }

            if (fireCount >= 3)
            {
                gun.HasAmmo.Should().BeFalse();
            }
            else
            {
                gun.HasAmmo.Should().BeTrue();
            }
        }
    }
}

