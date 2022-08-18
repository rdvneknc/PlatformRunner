using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public Button continueButton;

    void Update()
    {
        if (FinishFlag.levelOneEnded == true)
        {
            continueButton.gameObject.SetActive(true);
        }

        if(PaintPercentage.percentage >= 100)
        {
            continueButton.gameObject.SetActive(true);
        }

    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
