namespace BugHunter
{
    public interface IBug
    {
        void Dodge();
        void Hit();
        bool IsDead { get; }
        bool IsDodging { get; }

        void Miss();
    }
}