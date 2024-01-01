using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text status;

    void Awake()
    {
        //PlayerPrefs.SetInt("Name", 0);
        PlayerPrefs.SetInt("Fame", 0);
        PlayerPrefs.SetInt("Money", 0);
        status.text = "명성: " + PlayerPrefs.GetInt("Fame")
                    + "\n돈: " + PlayerPrefs.GetInt("Money") + "원";
    }
    
    public void StatusText()
    {
        status.text = "명성: " + PlayerPrefs.GetInt("Fame")
                    + "\n돈: " + PlayerPrefs.GetInt("Money") + "원";
    }

    private void Update()
    {
        StatusText();
    }
}
