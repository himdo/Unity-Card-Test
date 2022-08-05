public class Razor_Leaf : AttacksObject
{
    public Razor_Leaf()
    {
        this.Name = "Razor Leaf";
        this.Type = TypesEnum.Grass;
        this.AttackType = AttackTypeEnum.Physical;
        this.AttackDice = AttackDiceEnum.D6;
        this.FlavorText = "Attack all opposing Pokemon. This attak has a +1 critical hit ratio";
        this.AccuracyNumber = 2;
    }

    public override void OnActivate()
    {
        throw new System.NotImplementedException();
    }
}
