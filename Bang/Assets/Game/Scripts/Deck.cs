using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour {

    public GameObject deck;
    
  

    void Start () {
      
    }
	
	
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            deck.SetActive(true);
        }
        if (Input.GetMouseButtonUp(1))
        {
            deck.SetActive(false);
        }
        
	}



}
