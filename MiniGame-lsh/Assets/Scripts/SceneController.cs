using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string targetScene;
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene); //해당 씬으로 이동
    }
}
