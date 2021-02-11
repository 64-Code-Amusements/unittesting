namespace BugHunter
{
    public class StarshipTrooper : IStarshipTrooper
    {
        
        public StarshipTrooper(IRaygun blaster){
            Blaster = blaster;
        }
        public IRaygun Blaster {get; private set;}

        public void FireAt(IBug target)
        {
            if (Blaster?.CanFire ?? false )
            {
                Blaster.FireAt(target);
            }
        }

        public void LoadRaygun()
        {
            Blaster?.Recharge();
        }
    }
}