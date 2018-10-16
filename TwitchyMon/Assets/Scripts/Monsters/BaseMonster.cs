using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour {

    // MONSTER ATTRIBUTES
    protected string Name;
    protected int Level;
    protected int Experience;
    protected int AttackStock;

    // BATTLE STATS
    protected float Health;
    protected float Attack;
    protected float Defense;
    protected float Speed;

    // ATTACKS AND ATTACK STOCK
    protected Attack[] EquippedAttacks;
    protected List<Attack> AttackInventory;

    protected abstract void PerformAttack();

    protected abstract void HitByAttack(Attack _attack);
}