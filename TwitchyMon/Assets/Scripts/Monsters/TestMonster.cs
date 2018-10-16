using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonster : BaseMonster {

    // Base Monster holds all the stats

    public TestMonster() : base()
    {
        Name = "Default";
        Health = 100.0f;
        Attack = 15.0f;
        Defense = 8.0f;
        Speed = 10.0f;
        AttackStock = 6;
        Level = 1;
        Experience = 0;
    }

    public TestMonster(string _name, float _health, float _attack, float _defense, float _speed, int _attackstock = 6, int _level = 1, int _exp = 0) : base()
    {
        Name = _name;
        Health = _health;
        Attack = _attack;
        Defense = _defense;
        Speed = _speed;
        AttackStock = _attackstock;
        Level = _level;
        Experience = _exp;
    }

    // public variable for use in the inspector
    public KeyCode key;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // testing separate keys to simulate separate players attacking
        if (Input.GetKeyDown(key))
        {
            if (this.GetComponent<Attack>())
            {
                HitByAttack(this.GetComponent<Attack>());
            }
        }
	}

    public override void PerformAttack()
    {

    }

    public override void HitByAttack(Attack _attack)
    {
        // just to test attacking damage -> health deduction
        Health -= _attack.BaseDamage;
        print("Health : " + Health);
    }
}
