
namespace Heroes.Abstract
{
    internal interface IHero : IAttacable,IAttack
    {
        public string Name { get; set; }
        public IEnumerable<ISkill> Skills { get; }
    }
}
