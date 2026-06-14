using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunction : MonoBehaviour
{

    public void WelcomeScene(string WelcomeScene)
    {
        SceneManager.LoadScene("WelcomeScene");
    }
    public void TutorialOptionScene(string TutorialOptionScene)
    {
        SceneManager.LoadScene("TutorialOptionScene");
    }
    public void OnboardingSlide1(string OnboardingSlide1)
    {
        SceneManager.LoadScene("OnboardingSlide1");
    }
    public void OnboardingSlide2(string OnboardingSlide2)
    {
        SceneManager.LoadScene("OnboardingSlide2");
    }
    public void OnboardingSlide3(string OnboardingSlide3)
    {
        SceneManager.LoadScene("OnboardingSlide3");
    }
    public void OnboardingSlide4(string OnboardingSlide4)
    {
        SceneManager.LoadScene("OnboardingSlide4");
    }
    public void TrafficRulesScene(string TrafficRulesScene)
    {
        SceneManager.LoadScene("TrafficRulesScene");
    }
    public void TrafficRulesAR(string TrafficRulesAR)
    {
        SceneManager.LoadScene("TrafficRulesAR");
    }



    public void WelcomeScene()
    {
        Application.LoadLevel("WelcomeScene");
    }
    void OnboardingSlide1()
    {
        Application.LoadLevel("OnboardingSlide1");
    }
    public void OnboardingSlide2()
    {
        Application.LoadLevel("OnboardingSlide2");
    }
    public void OnboardingSlide3()
    {
        Application.LoadLevel("OnboardingSlide3");
    }
    public void TrafficRulesScene()
    {
        Application.LoadLevel("TrafficRulesScene");
    }


    public void ExitAR()
    {
        Application.Quit();
    }
}
