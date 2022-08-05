public class Tackle : AttacksObject
{
    public Tackle()
    {
        this.Name = "Tackle";
        this.Type = TypesEnum.Normal;
        this.AttackType = AttackTypeEnum.Physical;
        this.AttackDice = AttackDiceEnum.D4;
        this.FlavorText = "";
        this.AccuracyNumber = 1;
    }

    public override void OnActivate()
    {
        throw new System.NotImplementedException();
    }
}
