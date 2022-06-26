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

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Attacks/Attack", menuName = "Tools/Pokemon/Attack Object")]
public abstract class AttacksObject : ScriptableObject
{
    public string Name;
    public TypesEnum Type;
    public AttackTypeEnum AttackType;
    public AttackDiceEnum AttackDice;
    public string FlavorText;
    public int AccuracyNumber;
    public abstract void OnActivate(); 
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Ability/Ability", menuName = "Tools/Pokemon/Ability Object")]
public abstract class AbilityObject : ScriptableObject
{
    public string Name;
    public string FlavorText;
    public abstract void OnActivate();
}

[CreateAssetMenu(fileName = "Assets/ScriptableObjects/Cards/Card", menuName = "Tools/Pokemon/Card Stats")]
public class CardObject : ScriptableObject
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
}