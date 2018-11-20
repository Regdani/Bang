using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameScript : MonoBehaviour {

    public void PauseGame() {
        Debug.Log("Paused");
        Time.timeScale = 0;
    }

    public void ResumeGame() {
        Debug.Log("Resumed");
        Time.timeScale = 1;
    }
}
