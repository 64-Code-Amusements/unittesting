namespace BugHunter
{

    public class Raygun:IRaygun
    {

        private int battery = 3;

        public void FireAt(IBug bug)
        {
            if (!CanFire)
                return;
            if (bug.IsDodging)
                bug.Miss();
            else
                bug.Hit();
            battery--;
        }

        public void Recharge()
        {
            battery = 3;
        }

        public bool CanFire {get => battery > 0;}
    }
}
