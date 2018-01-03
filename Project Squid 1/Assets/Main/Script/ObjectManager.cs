using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum objectType { Others, Bullet, Player, Enemy, Wall }

public class ObjectManager : MonoBehaviour {

    [System.Serializable]
    public class GamePlayObject
    {
        [Header("General Setting")]
        public string unitName;
        public objectType type;
        public Transform transform;
        public float bornTime;

        [Header("HP / Damage Setting")]
        public int hpMax;
        public int hpCurrent;

        public LayerMask hitOn;
        public int hitDamage;
        public bool destroyOnHit;                   // bullet = true
        public Transform effectOnHit;

        public int expDamage;
        public int expForce;
        public bool expOnDie;
        public bool expOnTimer;
        public Transform effectOnExp;

        public bool destroyOnTimer;
        public float deadTime; 
        public Transform effectOnKilled;

        public void dueDamage(int damage)
        {
            hpCurrent -= damage;
        }        
    }

    [System.Serializable]
    public class Spawner
    {

        [System.Serializable]
        public class spawnable
        {
            public Transform theObject;
            public bool spawnOnce;
            public float burstCoolTime;
            public int amountOfRoundsInABurst;
            public float bulletCoolTime;
        }

        [Header("Spawner Setting")]

        public List<spawnable> objectToSpawn;

    }

    [System.Serializable]
    public class Moveable
    {

        [Header("Movment Setting")]

        public bool moveAble;
        public int mass;
        public float maxSpeed;
        public float currentSpeed;
        public bool pulsed; 

    }


    [System.Serializable]
    public class Grouping
    {
        [Header("Grouping Setting")]

        public bool groupAble;
        public bool isCenter;
        public bool isMember;
        public Grouping master;
        public List<Grouping> member;
        public List<spot> spots;

        public class spot
        {
            public Vector2 offest;
            public enum spotType { Attact, Protect, Wait }
        }
    }

    

    [ Header ("Set prefabs reference by unity editor")]
    public Transform player;
    public List<Transform> enemy;
    public List<Transform> bullet;

    public GamePlayObject test;
    public Spawner test2;
         

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
