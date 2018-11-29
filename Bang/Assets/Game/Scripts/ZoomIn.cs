using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour {

    public static string zoomActive = "n";
    void Start () {
		
	}
	
	
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            zoomActive = "y";
        }
    }
}
