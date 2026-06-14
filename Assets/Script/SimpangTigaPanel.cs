using System.Collections;
using UnityEngine;

public class SimpangTigaPanel : MonoBehaviour
{
    [Header("Confirmation Dialogs")]
    public GameObject exitDialog;
    public GameObject backDialog;

    [Header("UI Groups")]
    public GameObject bottomBarGroup;     // Group for all traffic rule info buttons (bottom bar)
    public GameObject mainButtonsGroup;   // Group for Back and Exit buttons

    // ===== Helper Methods =====
    private void ShowAllMainUI()
    {
        bottomBarGroup.SetActive(true);
        mainButtonsGroup.SetActive(true);
    }

    private void HideAllMainUI()
    {
        bottomBarGroup.SetActive(false);
        mainButtonsGroup.SetActive(false);
    }

    // ===== Open/Close Specific Info Panels =====
    public void OpenInfo(GameObject infoContentPanel)
    {
        infoContentPanel.SetActive(true);
        HideAllMainUI();
    }

    public void CloseInfo(GameObject infoContentPanel)
    {
        infoContentPanel.SetActive(false);
        ShowAllMainUI();
    }

    // ===== Exit Dialog Control =====
    public void ShowExitConfirmation()
    {
        exitDialog.SetActive(true);
        HideAllMainUI();
    }

    public void CancelExit()
    {
        exitDialog.SetActive(false);
        ShowAllMainUI();
    }

    public void QuitAR()
    {
        Application.Quit();
    }

    // ===== Back Dialog Control =====
    public void ShowBackConfirmation()
    {
        backDialog.SetActive(true);
        HideAllMainUI();
    }

    public void CancelBack()
    {
        backDialog.SetActive(false);
        ShowAllMainUI();
    }
}
