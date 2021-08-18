using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject introduction_page;
    
    public void Start_game( )
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

}
