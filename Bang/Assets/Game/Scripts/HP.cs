using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public float TotalHp = 100;
    public  float CurrentHp;
    public float a;
    public float moreArmor=0;
    public static HP hP;
   
    public Text pointText;


    void Start()
    {
        CurrentHp = TotalHp;
        TakeArmor(a);
    }

    

    void Update ()
    {
        if ( Draggable.take==false)
        {
            Draggable.take = true;

            HealthBar();
            
        }

    }

     void Awake()
    {
        hP = this;
    }


    public void TakeHeal(float heal)
    {
        if (CurrentHp!=100&&heal+CurrentHp<=100)
        {
            CurrentHp += heal;

            HealthBar();
        }
        
    }


    public  void TakeDamage(float damage)
    {
       
        
            if (CurrentHp != 0 && damage <= CurrentHp)
            {
                CurrentHp -= damage;
                HealthBar();
            }
        
                  
    }


   public void TakeArmor(float armor)
    {
        moreArmor += armor;
        pointText.text = moreArmor.ToString();
    }

    
    public void HealthBar()
    {
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
    }
}




//GiveDamage:
 //if (moreArmor!=0)
 //       {

 //           moreArmor -= damage;

 //       }
