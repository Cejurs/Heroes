using Heroes.Abstract;

namespace Heroes
{
    internal class Hero : IHero
    {
        public string Name { get; set; }

        private List<ISkill> _skills;
        public IEnumerable<ISkill> Skills { get => _skills; }
        public ILogger Logger { get; set; }

        public Hero(string name,ILogger logger)
        {
            Name = name;
            Logger = logger;
            _skills = new List<ISkill>();
        }

        public void LearnSkill(ISkill skill)
        {
            _skills.Add(skill);
        }
        public void Attack(IHero hero)
        {
            var message = $"{Name} attacks {hero.Name}";
            Logger.Log(message);
            var damage = 0.0;
            foreach(var skill in _skills)
            {
                skill.UseMethod();
                damage+= skill.GetFinalDamage();
            }
            hero.TakeDamage(damage,this);
        }


        public void TakeDamage(double damage,IHero hero)
        {
            var message = $"{Name} received {damage} damage from {hero.Name}";
            Logger.Log(message);
        }
    }
}
