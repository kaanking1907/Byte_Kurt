using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadCaptchaScene()
    {
        SceneManager.LoadScene("CaptchaScene");
    }
    public void LoadSettingsScene()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void LoadDepremScene()
    {
        SceneManager.LoadScene("DepremScene");
    }

    public string URL;
    public void LoadURL()
    {
        Application.OpenURL(URL);
    }

    public void SifremiUnuttum()
    {
        SceneManager.LoadScene("ForgotPassword");
    }
    
    public void LoadLogin()
    {
        SceneManager.LoadScene("LoginScene");
    }
}

