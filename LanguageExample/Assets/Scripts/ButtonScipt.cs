using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScipt : MonoBehaviour
{
    Language languageScript;

    void Start()
    {
        languageScript = GameObject.Find("Main Camera").GetComponent<Language>();
        GetAllText();
    }

    public void PlayButtonClick()
    {
        print("PLAY");
    }

    public void SettingsClick()
    {
        print("SETTINGS");
    }

    public void InfoClick()
    {
        print("INFO");
    }

    public void TurkceClick()
    {
        languageScript.language = "tr";
        PlayerPrefs.SetString("language", "tr");
        GetAllText();
    }

    public void IngilizceClick()
    {
        languageScript.language = "en";
        PlayerPrefs.SetString("language", "en");
        GetAllText();
    }

    public void FransizcaClick()
    {
        languageScript.language = "fr";
        PlayerPrefs.SetString("language", "fr");
        GetAllText();
    }

    private void GetAllText()
    {
        GameObject.Find("btnPlay").GetComponentInChildren<Text>().text = languageScript.GetText("play");
        GameObject.Find("btnSettings").GetComponentInChildren<Text>().text = languageScript.GetText("settings");
        GameObject.Find("btnInfo").GetComponentInChildren<Text>().text = languageScript.GetText("info");
    }
}
