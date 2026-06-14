using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitARManager : MonoBehaviour
{
    public GameObject infoPanel;
    public GameObject openInfoButton;
    public GameObject quitARButton;

    // Called when user clicks "i" button
    public void OpenInfo()
    {
        infoPanel.SetActive(true);
        openInfoButton.SetActive(false);
        quitARButton.SetActive(false); // Hide Quit AR button
    }

    // Called when user clicks "X" button
    public void CloseInfo()
    {
        infoPanel.SetActive(false);
        openInfoButton.SetActive(true);
        quitARButton.SetActive(true); // Show Quit AR button again
    }
}
