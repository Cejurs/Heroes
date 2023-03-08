using Heroes.Abstract;


namespace Heroes
{
    public enum IceColor
    {
        Red,
        Green,
        Blue,
        Yellow,
        White
    }
    internal class FreezeSkill : BaseSkill
    {
        public IceColor IceColor { get; set; }
        public double ReloadTime { get; set; }
        public FreezeSkill(string name, double damage, double damageRadius, ILogger logger,IceColor iceColor,double reloadTime) : 
            base(name, damage, damageRadius, logger)
        {
            if(reloadTime< 0 ) throw new ArgumentException(nameof(reloadTime));
            IceColor = iceColor;
            ReloadTime = reloadTime;
        }

        public override void UseMethod()
        {
            var message = $"Using {Name}. Base damage: {BaseDamage}. Radius {DamageRadius}. IceColor {IceColor}. ReloadTime {ReloadTime} ";
            Logger.Log(message);
        }
    }
}
