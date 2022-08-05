using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulbasaur : CardObject
{
    public Bulbasaur()

    {
        this.Name = "Bulbasaur";
        this.Stage = StageEnum.Basic;
        this.Gender = GenderEnum.Male;
        this.Types = new List<TypesEnum> { TypesEnum.Grass, TypesEnum.Poison };
        this.HowToEvolve = new List<HowToEvolveEnum> { HowToEvolveEnum.Level };
        this.ExpToLevel = new List<int> { 3 };
        this.CurrentExp = 0;
        this.CardNumber = 45;
        this._CardColor = CardColor.Green;

        this.HP = 10;
        this.Attack = 5;
        this.Defense = 5;
        this.SpAttack = 7;
        this.SpDefense = 7;
        this.Speed = 5;

        this.Ability = new Chlorophyll();
        this.Attacks = new List<AttacksObject> { new Razor_Leaf(), new Tackle(), new Sleep_Powder(), new Leach_Seed() };
        // TODO
        // this.EvolutionSprite;
        //this.Evolution = ;
        //this.FullImage = ;

    }
}
