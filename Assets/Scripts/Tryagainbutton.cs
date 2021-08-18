using UnityEngine;
using UnityEngine.SceneManagement;

public class Tryagainbutton : MonoBehaviour
{
    public void LoadNewLevel()
    {
        FindObjectOfType<AudioManager>().Play("try_again");
    }
    public void Fail_Tryagain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
