﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float accuracy;
    public float power;
    public float chargeTime;
    public float hitTime;
    public int APCost;
    public ElementalType type;
    public int MoveID;
    public float hp;
    public GameObject projectile;
    public bool ranged;
    public float PracticalityDamageModifyer;
    public bool mustStandStill;
    public GameObject AttachedExemon;
    public float resistance;

    public List<HitBoxForce> hitBoxes;


    
    private void Update()
    {

    }

    public void ResolveHit(BattleExemon exemon, float stunDuration)
    {
        Debug.Log(stunDuration);
        exemon.finishedAttack = true;
        exemon.TakeDamage(power);
        exemon.ApplyStun(stunDuration);
    }


    public void AssignExemonHitBoxes()
    {
        
    }


}

public enum moveType
{
    Attack,
    Enchant,
    Affliction,

}


