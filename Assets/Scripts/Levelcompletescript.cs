using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcompletescript : MonoBehaviour
{

    public void LoadNewLevel ( )
    {
        FindObjectOfType<AudioManager>().Play("middle_music");
    }
    public void NextLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
