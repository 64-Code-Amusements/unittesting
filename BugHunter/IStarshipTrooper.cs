namespace BugHunter {
    public interface IStarshipTrooper
    {
        IRaygun Blaster {get;}
        void LoadRaygun();
        void FireAt(IBug target);


    }
}