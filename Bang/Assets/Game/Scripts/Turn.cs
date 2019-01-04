using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour {

    public bool turnPlayer = true;
    public float armor;
    public float damage;
    public float heal;
    public bool huzhat;
    public  int lapok=1;
    public int kijatszottLapok;
    public GameObject hand;
    
    System.Random rnd = new System.Random();

    public static Turn turn;


    void Start()
    {
        while (lapok != 4)
        {
            Draw.draw.huzas();
            lapok++;
        }
        huzhat = false;

        
    }

    void Update()
    {
        
        if (turnPlayer)
        {
            
            if (kijatszottLapok != 3)
            {

                if (huzhat == true)
                {

                    while (hand.transform.childCount!=4)
                    {
                        Draw.draw.huzas();
                    }
                    
                       
                   
                    

                    huzhat = false;
                }
                
                
            }
            else
            {
                hand.SetActive(false);
            }
           
        }
        else
        {
            hand.SetActive(true);
            kijatszottLapok = 0;
            Enemy();
            huzhat = true;
        }
        
    }


     void Awake()
    {
        turn = this;
    }


    public void TurnChange()
    {
        turnPlayer = !turnPlayer;
    }

    public void Enemy()
    {
        HP.hP.Armor(armor = rnd.Next(5, 10 ));
        SHp.sHp.GiveDamage(damage = rnd.Next(9, 20));
        HP.hP.TakeHeal(heal = rnd.Next(5, 15));
        turnPlayer = !turnPlayer;
    }
}
