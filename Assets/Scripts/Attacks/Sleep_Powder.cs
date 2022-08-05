public class Sleep_Powder : AttacksObject
{
    public Sleep_Powder()
    {
        this.Name = "Sleep Powder";
        this.Type = TypesEnum.Grass;
        this.AttackType = AttackTypeEnum.Status;
        this.AttackDice = AttackDiceEnum.Null;
        this.FlavorText = "Target falls asleep.";
        this.AccuracyNumber = 6;
    }

    public override void OnActivate()
    {
        throw new System.NotImplementedException();
    }
}
