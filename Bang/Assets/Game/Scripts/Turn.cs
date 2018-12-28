using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

    public bool turnPlayer = true;
    public float armor;
    public float damage;
    public float heal;
    System.Random rnd = new System.Random();


    void Start()
    {

    }

    void Update()
    {
        
        if (turnPlayer)
        {
            Debug.Log("Player's turn");
        }
        else
        {
            HP.hP.Armor(armor = rnd.Next(5, 15 + 1));
            SHp.sHp.GiveDamage(damage = rnd.Next(5, 7 + 1));
            HP.hP.TakeHeal(heal = rnd.Next(2, 12 + 1));
            turnPlayer=!turnPlayer;
        }
    }


   
    public void TurnChange()
    {
        turnPlayer = !turnPlayer;
    }
}
