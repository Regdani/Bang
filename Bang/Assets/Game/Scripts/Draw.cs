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
        int veletlen = rnd.Next(1, 12 + 1);
        if (veletlen == 1)
        {
            card = Instantiate(bang);
            
        }

        if (veletlen == 2)
        {
            card = Instantiate(kinfe);
        }

        if (veletlen == 3)
        {
            card = Instantiate(punch);
        }
        if (veletlen == 4)
        {
            card = Instantiate(springfield);
        }
        if (veletlen == 5)
        {
            card = Instantiate(beer);
        }
        if (veletlen == 6)
        {
            card = Instantiate(flask);
        }
        if (veletlen == 7)
        {
            card = Instantiate(tequila);
        }
        if (veletlen == 8)
        {
            card = Instantiate(whisky);
        }
        if (veletlen == 9)
        {
            card = Instantiate(bible);
        }
        if (veletlen == 10)
        {
            card = Instantiate(cowboyhat);
        }
        if (veletlen == 11)
        {
            card = Instantiate(ironplate);
        }
        if (veletlen == 12)
        {
            card = Instantiate(sombrero);
        }

        card.SetActive(true);
        card.transform.SetParent(hand);
      
    }

    
   
}

