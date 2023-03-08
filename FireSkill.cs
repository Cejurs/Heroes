using Heroes.Abstract;

namespace Heroes
{
    internal class FireSkill : BaseSkill
    {
        public int BurningTime { get; set; }
        public FireSkill(string name, double damage, double damageRadius, ILogger logger,int burningTime) : 
            base(name, damage, damageRadius, logger)
        {
            if(burningTime<0) throw new ArgumentException(nameof(burningTime));
            BurningTime = burningTime;
        }

        public override void UseMethod()
        {
            var message = $"Using {Name}. Base damage: {BaseDamage}. Radius {DamageRadius}. FireTime {BurningTime} ";
            Logger.Log(message);
        }
    }
}
