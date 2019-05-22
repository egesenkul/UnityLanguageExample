using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    public string language;

    Dictionary<string, string> TurkceTextler;
    Dictionary<string, string> IngilizceTextler;
    Dictionary<string, string> FransizcaTextler;

    // Start is called before the first frame update
    void Start()
    {
       language = PlayerPrefs.GetString("language", "tr");

        SetTextler();
        SetTurkce();
        SetIngilizce();
        SetFransizca();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetTextler()
    {
        TurkceTextler = new Dictionary<string, string>();
        IngilizceTextler = new Dictionary<string, string>();
        FransizcaTextler = new Dictionary<string, string>();
    }

    void SetTurkce()
    {
        TurkceTextler.Add("play", "OYNA");
        TurkceTextler.Add("info", "BİLGİ");
        TurkceTextler.Add("settings", "AYARLAR");
    }

    void SetIngilizce()
    {
        IngilizceTextler.Add("play", "PLAY");
        IngilizceTextler.Add("info", "INFO");
        IngilizceTextler.Add("settings", "SETTINGS");
    }

    void SetFransizca()
    {
        FransizcaTextler.Add("play", "JOUER");
        FransizcaTextler.Add("info", "LÖ BİLGİ");
        FransizcaTextler.Add("settings", "LÖ SETTİNGS");
    }

    public string GetText(string key)
    {
        string result = string.Empty;
        switch (language)
        {
            case "tr":
                result = TurkceTextler[key];
                break;
            case "en":
                result = IngilizceTextler[key];
                break;
            case "fr":
                result = FransizcaTextler[key];
                break;
        }
        return result;
    }
}
