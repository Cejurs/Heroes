namespace Heroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var swordhero = SimpleManufacture.CreateHero(HeroType.Sword);
            var firehero = SimpleManufacture.CreateHero(HeroType.FireSword);
            var freezehero = SimpleManufacture.CreateHero(HeroType.IceSword);

            swordhero.Attack(firehero);
            firehero.Attack(freezehero);
            freezehero.Attack(swordhero);
        }
    }
}