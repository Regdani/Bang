using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float damage;
    public float heal;
    public float armor;
  public static  Enemy enemy;
	
	void Start () {
        Gen();
        Debug.Log(damage);
        Debug.Log(armor);
        Debug.Log(heal);
	}
	
	
	void Update () {
		
	}

     void Awake()
    {
        enemy = this;
    }

  public  void Gen()
    {
       System.Random rnd = new System.Random();
        damage = rnd.Next(5,7+1);
        armor = rnd.Next(5,15+1);
        heal = rnd.Next(2, 12 + 1);
        
    }
}
