using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    
    public void Quit( )
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

}
