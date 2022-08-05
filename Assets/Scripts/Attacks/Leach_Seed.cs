public class Leach_Seed : AttacksObject
{
    public Leach_Seed()
    {
        this.Name = "Leech Seed";
        this.Type = TypesEnum.Grass;
        this.AttackType = AttackTypeEnum.Status;
        this.AttackDice = AttackDiceEnum.Null;
        this.FlavorText = "Target takes 2 damage at the end of each turn. Heal 2 HP from your active in return.";
        this.AccuracyNumber = 3;
    }

    public override void OnActivate()
    {
        throw new System.NotImplementedException();
    }
}
