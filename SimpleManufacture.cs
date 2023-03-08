using Heroes.Abstract;


namespace Heroes
{
    public enum HeroType
    {
        Sword,
        IceSword,
        FireSword
    }
    internal static class SimpleManufacture
    {
        public static IHero CreateHero(HeroType heroType)
        {
            ILogger logger;
            ISkill skill;
            switch(heroType)
            {
                case HeroType.Sword:
                    logger = new Logger(ConsoleColor.Green);
                    var swordhero = new Hero("SwordHero", logger);
                    skill = new SwordSkill("Sword", 20, 1, logger, 2);
                    swordhero.LearnSkill(skill);
                    return swordhero;
                case HeroType.IceSword:
                    logger = new Logger(ConsoleColor.Blue);
                    var icehero = new Hero("SwordFreezeHero", logger);
                    skill = new SwordSkill("Sword", 10, 1, logger, 3);
                    icehero.LearnSkill(skill);
                    skill = new FreezeSkill("Freeze", 20, 2, logger, IceColor.Blue, 2);
                    icehero.LearnSkill(skill);
                    return icehero;
                case HeroType.FireSword:
                    logger = new Logger(ConsoleColor.Red);
                    var firehero = new Hero("SwordFireHero", logger);
                    skill = new SwordSkill("Sword", 10, 1, logger, 3);
                    firehero.LearnSkill(skill);
                    skill = new FireSkill("Fire", 20, 2, logger,4);
                    firehero.LearnSkill(skill);
                    return firehero;
                default:
                    throw new ArgumentException("Unknown type of hero");
            }
        }
    }
}
