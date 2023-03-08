
using Heroes.Abstract;

namespace Heroes
{
    internal class BaseSkill: ISkill, ILoggable
    {
        public string Name { get; set; }
        public double BaseDamage { get; set; }
        public double DamageRadius { get; set; }
        public ILogger Logger { get; set; }

        public BaseSkill(string name, double basedamage, double damageRadius, ILogger logger)
        {
            if (basedamage < 0) throw new ArgumentException(nameof(basedamage));
            if (damageRadius < 0) throw new ArgumentException(nameof(damageRadius));
            Name = name;
            BaseDamage = basedamage;
            DamageRadius = damageRadius;
            Logger = logger;
        }

        public virtual void UseMethod()
        {
            var message = $"Using {Name}. Base damage: {BaseDamage}. Radius {DamageRadius}.";
            Logger.Log(message);
        }

        public virtual double GetFinalDamage()
        {
            return BaseDamage;
        }
    }
}
