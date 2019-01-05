using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndLoad : MonoBehaviour {
    public VideoPlayer videoPlayer;
    private void Update()
    {

        if (videoPlayer.isPlaying)
        {
            Debug.Log("megy");
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
        
    }
    
}
