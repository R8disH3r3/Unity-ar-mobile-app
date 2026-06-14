using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class TrafficRuleSelection : MonoBehaviour
{
    public GameObject backDialogPanel;             // Assign the dialog panel in Inspector
    public TrafficRuleSelection straightRoad;      // Assign the script in Inspector
    public TrafficRuleSelection tJunction;
    public TrafficRuleSelection roundabout2;
    public TrafficRuleSelection roundabout3;
    // Called when user clicks the back arrow button

    [Serializable]
    public class RuleButton
    {
        public Button button;
        public string sceneName;
    }

    public Button startButton;
    public RuleButton[] ruleButtons;

    public Color selectedColor = Color.green;
    public Color defaultColor = Color.white;

    private string selectedScene = "";
    private Button selectedButton;

    void Start()
    {
        startButton.interactable = false;

        foreach (RuleButton rb in ruleButtons)
        {
            rb.button.GetComponent<Image>().color = defaultColor;

            // Add listener dynamically
            Button localButton = rb.button;
            string localScene = rb.sceneName;

            localButton.onClick.AddListener(() => SelectTrafficRule(localButton, localScene));
        }
    }

    public void SelectTrafficRule(Button btn, string sceneName)
    {
        selectedScene = sceneName;
        startButton.interactable = true;
        selectedButton = btn;

        foreach (RuleButton rb in ruleButtons)
        {
            rb.button.GetComponent<Image>().color = (rb.button == btn) ? selectedColor : defaultColor;
        }
    }

    public void StartARScene()
    {
        Debug.Log("Start Button Pressed, scene: " + selectedScene);
        if (!string.IsNullOrEmpty(selectedScene))
        {
            SceneManager.LoadScene(selectedScene);
        }
    }

    //Used to enable or disable interaction with all traffic rule and start buttons
    public void SetButtonsInteractable(bool isInteractable)
    {
        foreach (RuleButton rb in ruleButtons)
        {
            rb.button.interactable = isInteractable;
        }

        // Start button only enabled if scene is selected and interactivity is allowed
        startButton.interactable = isInteractable && !string.IsNullOrEmpty(selectedScene);
    }

    public void OpenBackConfirmation()
    {
        backDialogPanel.SetActive(true);             // Show the confirmation dialog
        tJunction.SetButtonsInteractable(false); // Disable all traffic rule buttons and start button
        straightRoad.SetButtonsInteractable(false);
        roundabout2.SetButtonsInteractable(false);
        roundabout3.SetButtonsInteractable(false);
    }

    // Called when user clicks "No" on the dialog
    public void CloseBackConfirmation()
    {
        backDialogPanel.SetActive(false);            // Hide the confirmation dialog
        tJunction.SetButtonsInteractable(true);  // Re-enable the buttons
        straightRoad.SetButtonsInteractable(true);
        roundabout2.SetButtonsInteractable(true);
        roundabout3.SetButtonsInteractable(true);
    }

    // Called when user clicks "Yes" on the dialog
    public void ConfirmBackToWelcome()
    {
        SceneManager.LoadScene("WelcomeScene");             // Load the welcome scene
    }
}
