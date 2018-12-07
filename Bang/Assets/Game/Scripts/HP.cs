using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public float TotalHp=100;
    public float CurrentHp;
    public float damage;
    public float heal = 5;

     void Start()
    {
        CurrentHp = TotalHp;
        

    }

  

        void Update ()
    {
        if ( Draggable.take==false)
        {
            Draggable.take = true;
            TakeDamage();
            
        }

        

        if (Input.GetMouseButtonDown(1))
        {
            TakeHeal();
        }
    }

    public void TakeHeal()
    {
       
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
        if (CurrentHp == 100)
        {
            heal = 0;
        }
        else
        {
            heal = 5;
        }
        CurrentHp += heal;
    }

   public void TakeDamage()
    {
        CurrentHp -= damage;
        
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
        if (CurrentHp == 0)
        {
            damage = 0;
        }
        else
        {
            damage = 5;
        }
    }
}
