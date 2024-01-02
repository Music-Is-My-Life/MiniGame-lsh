using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text status;

    void Start()
    {
        StatusText();
    }
    
    public void StatusText()
    {
        status.text = "명성: " + PlayerPrefs.GetInt("Fame")
                    + "\n돈: " + PlayerPrefs.GetInt("Money") + "원";
    }
}
