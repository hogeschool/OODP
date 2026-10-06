/*
- ASCII: Read-only. if alive @"^(;,;)^" if dead @"^(-,,,-)^"
- Attack: returns 3
- Defend: the given damage is taken off the CurrentHitPoints  
*/

public class Monster : Player
{
    public override string ASCII => CurrentHitPoints > 0
        ? "^(;,;)^"
        : "^(-,,,-)^";

    public Monster(string name, int maximumHitPoints)
        : base(name, maximumHitPoints)
    {

    }

    public override int Attack() => 3;
}
