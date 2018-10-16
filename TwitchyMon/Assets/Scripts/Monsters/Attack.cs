using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AttackType { Basic, /* ADD TYPES AS NEEDED*/ }

public class Attack : MonoBehaviour {

    public string Name;
    public float BaseDamage;
    public AttackType Type;

}
