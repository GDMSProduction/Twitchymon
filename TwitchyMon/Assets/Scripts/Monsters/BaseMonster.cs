using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour {

    // MONSTER ATTRIBUTES
    public string Name { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public int AttackStock { get; set; }

    // BATTLE STATS
    public float Health { get; set; }
    public float Attack { get; set; }
    public float Defense { get; set; }
    public float Speed { get; set; }

    // ATTACKS AND ATTACK STOCK
    public Attack[] EquippedAttacks;
    public List<Attack> AttackInventory;

    public List<BaseMonster> enemyMonsters;

    public abstract void PerformAttack();

    public abstract void HitByAttack(Attack _attack);
    
}