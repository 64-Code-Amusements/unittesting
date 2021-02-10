namespace BugHunter
{
    public class Bug : IBug
    {

        public bool IsDodging { get; private set; } = false;
        public bool IsDead {get; private set;} = false;

        public void Dodge()
        {
            IsDodging = true;
        }

        public void Hit()
        {
            IsDead = true;
        }

        public void Miss()
        {
            IsDodging = false;
        }

    }
}
