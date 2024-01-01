using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string targetScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene); //해당 씬으로 이동
    }
    
    // Start is called before the first frame update
    void Awake()
    {
        PlayerPrefs.SetInt("Name", 0);
        PlayerPrefs.SetInt("Fame", 0);
        PlayerPrefs.SetInt("Money", 0);
    }

}
