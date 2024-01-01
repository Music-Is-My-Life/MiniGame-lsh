using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializeStatus : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("Fame", 0);
        PlayerPrefs.SetInt("Money", 0);
    }
}
