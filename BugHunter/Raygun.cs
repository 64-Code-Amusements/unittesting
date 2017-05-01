namespace BugHunter
{

    public class Raygun
    {

        private int ammo = 3;

        public void FireAt(IBug bug)
        {
            if (!HasAmmo)
                return;
            if (bug.IsDodging)
                bug.Miss();
            else
                bug.Hit();
            ammo--;
        }

        public void Recharge()
        {
            ammo = 3;
        }

        public bool HasAmmo
        {
            get
            {
                return ammo > 0;
            }
        }
    }
}
