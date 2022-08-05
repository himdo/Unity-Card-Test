public abstract class AttacksObject
{
    public string Name;
    public TypesEnum Type;
    public AttackTypeEnum AttackType;
    public AttackDiceEnum AttackDice;
    public string FlavorText;
    public int AccuracyNumber;
    public abstract void OnActivate();
}