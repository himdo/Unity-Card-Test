using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StageEnum
{
    Basic,
    Stage_1,
    Stage_2
}

public enum GenderEnum
{
    Male,
    Female,
    None
}

public enum TypesEnum
{
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dark,
    Dragon,
    Steel,
    Fairy
}

public enum HowToEvolveEnum
{
    Level,
    Item
}

public enum ItemEnum
{
    Null
}

public enum AttackTypeEnum
{
    Physical,
    Special,
    Status
}

public enum AttackDiceEnum
{
    Null,
    D4,
    D6,
    D8,
    D12,
    D20,
    Questions
}

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

public abstract class AbilityObject
{
    public string Name;
    public string FlavorText;
    public abstract void OnActivate();
}

public class CardObject
{
    public string Name;
    public StageEnum Stage;
    public GenderEnum Gender;
    public List<TypesEnum> Types;
    public List<HowToEvolveEnum> HowToEvolve;
    public List<ItemEnum> EvolutionItem;
    public List<Sprite> EvolutionSprite;
    public List<int> ExpToLevel; // -1 is equal to null
    public int CurrentExp;
    public List<CardObject> Evolution;
    public int CardNumber; // TODO figure out what this is
    public Color CardColor; // TODO figure out what this is

    public Sprite BackgroundImage;
    public Sprite PokemonImage;

    public int HP;
    public int Attack;
    public int Defense;
    public int SpAttack;
    public int SpDefense;
    public int Speed;

    public AbilityObject Ability;
    public List<AttacksObject> Attacks;

    public CardObject(string Name, 
                      StageEnum Stage, 
                      GenderEnum Gender, 
                      List<TypesEnum> Types, 
                      List<HowToEvolveEnum> HowToEvolve,
                      List<ItemEnum> EvolutionItem,
                      List<Sprite> EvolutionSprite,
                      List<int> ExpToLevel,
                      int CurrentExp,
                      List<CardObject> Evolution,
                      int CardNumber,
                      Color CardColor,
                      Sprite BackgroundImage,
                      Sprite PokemonImage,
                      int HP,
                      int Attack,
                      int Defense,
                      int SpAttack,
                      int SpDefense,
                      int Speed,
                      AbilityObject Ability,
                      List<AttacksObject> Attacks)
    {
        this.Name = Name;
        this.Stage = Stage;
        this.Gender = Gender;
        this.Types = Types;
        this.HowToEvolve = HowToEvolve;
        this.EvolutionItem = EvolutionItem;
        this.EvolutionSprite = EvolutionSprite;
        this.ExpToLevel = ExpToLevel;
        this.CurrentExp = CurrentExp;
        this.Evolution = Evolution;
        this.CardNumber = CardNumber;
        this.CardColor = CardColor;
        this.BackgroundImage = BackgroundImage;
        this.PokemonImage = PokemonImage;
        this.HP = HP;
        this.Attack = Attack;
        this.Defense = Defense;
        this.SpAttack = SpAttack;
        this.SpDefense = SpDefense;
        this.Speed = Speed;
        this.Ability = Ability;
        this.Attacks = Attacks;
    }
}