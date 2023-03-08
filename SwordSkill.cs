

using Heroes.Abstract;

namespace Heroes
{
    internal class SwordSkill : BaseSkill
    {
        public double DamageMultiplier { get; set; }
        public SwordSkill(string name, double damage, double damageRadius, ILogger logger,double damageMultiplier) : 
            base(name, damage, damageRadius, logger)
        {
            if(damageMultiplier<0) throw new ArgumentException(nameof(damageMultiplier));
            DamageMultiplier = damageMultiplier;
        }

        public override void UseMethod()
        {
            var message = $"Using Sword. Base damage: {BaseDamage}. OverallDamage {BaseDamage * DamageMultiplier}. Radius {DamageRadius}. DamageMultiplayer {DamageMultiplier} ";
            Logger.Log(message);
        }

        public override double GetFinalDamage()
        {
            return BaseDamage * DamageMultiplier;
        }
    }
}
