using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOut : MonoBehaviour {

	
	void Start () {
        GetComponent<Camera>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (ZoomIn.zoomActive == "y")
        {
            GetComponent<Camera>().enabled = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            GetComponent<Camera>().enabled = false;
            ZoomIn.zoomActive = "n";
        }
    }
}
