using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public float TotalHp = 100;
    public  float CurrentHp;
  
    public static HP hP;
   

    void Start()
    {
        CurrentHp = TotalHp;

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

        if (CurrentHp!=0&&damage<=CurrentHp)
        {
            CurrentHp -= damage;
            HealthBar();
        }
           
        
        

                  
    }

    public void HealthBar()
    {
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
    }
}
