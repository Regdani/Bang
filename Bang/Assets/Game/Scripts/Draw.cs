using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour {
    public GameObject bang;
    public GameObject kinfe;
    public GameObject punch;
    public GameObject springfield;
    public GameObject beer;
    public GameObject flask;
    public GameObject tequila;
    public GameObject whisky;
    public GameObject bible;
    public GameObject cowboyhat;
    public GameObject ironplate;
    public GameObject sombrero;
    private GameObject card;
    public Transform hand;
    
    
    


    System.Random rnd = new System.Random();

    public static Draw draw;


     void Awake()
    {
        draw = this;
    }


   public  void huzas () {
        int veletlen = rnd.Next(0, 15 + 1);
        if (veletlen <= 2 && veletlen > 0)
        {
            card = Instantiate(bang);
            
        }

        if (veletlen <= 4&&veletlen>2)
        {
            card = Instantiate(kinfe);
        }

        if (veletlen <= 6 && veletlen > 4)
        {
            card = Instantiate(punch);
        }
        if (veletlen <= 8 && veletlen > 6)
        {
            card = Instantiate(springfield);
        }
        if (veletlen==9)
        {
            card = Instantiate(beer);
        }
        if (veletlen ==10)
        {
            card = Instantiate(flask);
        }
        if (veletlen ==11)
        {
            card = Instantiate(tequila);
        }
        if (veletlen ==12)
        {
            card = Instantiate(whisky);
        }
        if (veletlen==13)
        {
            card = Instantiate(bible);
        }
        if (veletlen==14)
        {
            card = Instantiate(cowboyhat);
        }
        if (veletlen==15)
        {
            card = Instantiate(ironplate);
        }
        if (veletlen == 16)
        {
            card = Instantiate(sombrero);
        }

        
        card.transform.SetParent(hand);
      
    }

    
   
}

