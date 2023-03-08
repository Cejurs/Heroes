namespace Heroes.Abstract
{
    internal interface ISkill
    {
        public string Name { get; set; }
        public double BaseDamage { get; set; }
        public double DamageRadius { get; set; }
        public void UseMethod();

        public double GetFinalDamage();
    }
}
