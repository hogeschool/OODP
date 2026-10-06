public class Knight : Player
{
    public override string ASCII => CurrentHitPoints > 0
        ? "{._.} -{---"
        : "{-_-}";
    public Weapon EquippedWeapon { get; set; }
    public Armor EquippedArmor { get; set; }

    public Knight(
        string name, int maximumHitPoints,
        Weapon weapon, Armor armor)
        : base(name, maximumHitPoints)
    {
        EquippedWeapon = weapon;
        EquippedArmor = armor;
    }

    public override int Attack()
    {
        return RandomGenerator.Next(EquippedWeapon.Strength) + 1;
    }

    public override void Defend(int damage)
    {
        damage -= EquippedArmor == null
            ? 0
            : EquippedArmor.Defense;
        damage = Math.Max(damage, 0);)
        base.Defend(damage);
    }
}
