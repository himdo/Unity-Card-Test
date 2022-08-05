using System.Collections.Generic;
using UnityEngine;

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
    public CardColor _CardColor; // TODO figure out what this is

    public Sprite BackgroundImage;
    public Sprite PokemonImage;
    public Sprite FullImage;

    public int HP;
    public int Attack;
    public int Defense;
    public int SpAttack;
    public int SpDefense;
    public int Speed;

    public AbilityObject Ability;
    public List<AttacksObject> Attacks;

}