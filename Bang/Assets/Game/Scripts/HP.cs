using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour {

    public float TotalHp = 100;
    public  float CurrentHp;
    public static HP hP;
    public TextMeshProUGUI hp;
    public Text arm;
    public float a;
    public float moreArmor;

    
    void Start()
    {
        CurrentHp = TotalHp;
        
        hp.text = CurrentHp.ToString();
        
    }

    

    void Update ()
    {
        
            HealthBar();
            hp.text = CurrentHp.ToString();
            Armor(a);
    }

     void Awake()
     {
        hP = this;
     }


    public void TakeHeal(float heal)
    {
        if (CurrentHp!=100)
        {
            if (heal+CurrentHp>100)
            {
                heal = 100 - CurrentHp;
            }
            CurrentHp += heal;

            HealthBar();

        }
        
    }


    public  void GiveDamage(float damage)
    {


        if (moreArmor != 0)
        {
            if (moreArmor < damage)
            {
                damage -= moreArmor;
                moreArmor = 0;
                CurrentHp -= damage;
                HealthBar();

            }
            else
            {
                moreArmor -= damage;
            }

            arm.text = moreArmor.ToString();
        }
        else if ((CurrentHp != 0))
        {
            if (CurrentHp < damage)
            {
                damage = CurrentHp;

            }
            CurrentHp -= damage;
            HealthBar();

        }

    }



    public void Armor(float armor)
    {
        moreArmor += armor;
        arm.text = moreArmor.ToString();
    }

    
    public void HealthBar()
    {
        hp.text = CurrentHp.ToString();
        transform.localScale = new Vector3((CurrentHp / TotalHp), 1, 1);
        
    }
}





