namespace BugHunter
{
    public class Bug : IBug
    {

        private bool dodging;
        private bool dead;

        public void Dodge()
        {
            dodging = true;
        }

        public void Hit()
        {
            dead = true;
        }

        public void Miss()
        {
            dodging = false;
        }

        public bool IsDodging
        {
            get
            {
                return dodging;
            }
        }

        public bool IsDead
        {
            get
            {
                return dead;
            }
        }
    }
}
