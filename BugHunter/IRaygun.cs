namespace BugHunter
{

    public interface IRaygun
    {
        void FireAt(IBug bug);

         void Recharge();

        bool CanFire { get; }
    }
}