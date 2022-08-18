using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text gameOverText;
    public bool canQuit = false;

    private void Update()
    {
        if (FinishFlag.levelThreeEnded == true)
        {
            canQuit = true;
            Time.timeScale = 0;
            gameOverText.gameObject.SetActive(true);
            
        
        }

        if (canQuit == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
       
    }  
    
    
}
