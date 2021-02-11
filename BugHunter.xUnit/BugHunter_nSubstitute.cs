using Xunit;
using NSubstitute;

namespace BugHunter.xUnit
{

    public class BugHunter_nSubstitue
    {
        [Fact]
        public void TryShootingBug()
        {
            var bug = Substitute.For<IBug>();
            bug.IsDodging.Returns(false);
            var gun = new Raygun();

            gun.FireAt(bug);

            bug.Received().Hit();
            bug.DidNotReceive().Miss();
        }

        [Fact]
        public void TryShootingADodgingBug()
        {
            var bug = Substitute.For<IBug>();
            bug.IsDodging.Returns(true);
            var gun = new Raygun();

            gun.FireAt(bug);

            bug.DidNotReceive().Hit();
            bug.Received().Miss();
        }

        [Fact]
        public void WhenTrooperFiresBlasterIsDischarged()
        {
            var mBlaster = Substitute.For<IRaygun>();
            mBlaster.CanFire.Returns(true);
            var mTarget = Substitute.For<IBug>();
            var mOther = Substitute.For<IBug>();
            var trooper = new StarshipTrooper(mBlaster);

            trooper.FireAt(mTarget);

             mBlaster.Received().FireAt(mOther);
            mBlaster.Received().FireAt(mTarget);
        }
    }
}

