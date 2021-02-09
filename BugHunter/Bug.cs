namespace BugHunter
{
    public class Bug : IBug
    {

        public bool IsDodging {get; private set;}= true;
        private bool dead;

        public void Dodge()
        {
            IsDodging = true;
        }

        public void Hit()
        {
            dead = true;
        }

        public void Miss()
        {
            IsDodging = false;
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
