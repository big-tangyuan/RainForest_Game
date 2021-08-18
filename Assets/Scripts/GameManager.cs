using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    public GameObject faillevelUI;
    public player_movement movement;

    public void Completelevel()
    {
        if(FindObjectOfType<score>().destroyedmoon < 5f)
        {
            FindObjectOfType<AudioManager>().Play("try_again");
            faillevelUI.SetActive(true);
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("success");
            completeLevelUI.SetActive(true);
        }
        movement.enabled = false;
    }

    public void EndGame()
    {
        if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game Over!");
            FindObjectOfType<AudioManager>().Play("try_again");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
