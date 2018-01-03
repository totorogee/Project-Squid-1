using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum objectType { Player, Enemy, Bullet, Wall }

public class ObjectManager : MonoBehaviour {

    [System.Serializable]
    public class AllObject
    {
        [Header("General Object Setting")]
        public string unitName;
        public objectType type = objectType.Wall;
        public Transform transform;
        public int mass;

        public int hpMax;
        public int hpCurrent;

        public LayerMask hitOn;
        public Transform effectOnHit;
        public Transform effectOnKilled;
        public Transform effectOnExp;

        public int hitDamage;
        public bool destroyOnHit;
        public bool destroyOnTimer;
        public int damageOnHit;
        public int expDamage;
        public int expForce;
        public bool expOnDie;
        public bool expOnTimer;
        public float timer;


        public void dueDamage(AllObject target , int damage)
        {
            target.hpCurrent -= damage;
        }        
    }

    [System.Serializable]
    public class Shooter : AllObject
    {
        [Header("Shoot And Movement Setting")]
        public Transform bullet;
        public bool shootOnPlayer;
        public bool shootOnBase;
        public float burstCoolTime;
        public int amountOfRoundsInABurst;
        public float bulletCoolTime;
    }

    [ Header ("Set prefabs reference by unity editor")]
    public Transform player;
    public List<Transform> enemy;
    public List<Transform> bullet;

    public AllObject test;
    public Shooter test2;
         

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
