namespace StrategyPatternProject
{
    public class Fighter
    {
        private IFighter fighter;
        
        public int Health { get; set; }
       
        public void ChangeMood(IFighter fighter)
        {
            this.fighter = fighter;
            this.fighter.Fight();
        }

    }
}
