using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoreText;
    public Text moon_number;
    public Text level;
    public float destroyedmoon = 0f;
    public GameObject perfect_image;
    public GameObject great_image;
    public GameObject excellent_image;
    public GameObject qualified_image;
    public GameObject failed_image;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        moon_number.text = destroyedmoon+"/5";
        if(destroyedmoon == 11f)
        {
            level.text = "PERFECT!\nDestroyed "+destroyedmoon+" Moonstones!";
            perfect_image.SetActive(true);
            excellent_image.SetActive(false);
            great_image.SetActive(false);
            qualified_image.SetActive(false);
            failed_image.SetActive(false);
        }
        else if(destroyedmoon == 9f || destroyedmoon == 10f)
        {
            level.text = "EXCELLENT!\nDestroyed " + destroyedmoon + " Moonstones!";
            perfect_image.SetActive(false);
            excellent_image.SetActive(true);
            great_image.SetActive(false);
            qualified_image.SetActive(false);
            //failed_image.SetActive(false);
        }
        else if (destroyedmoon == 7f || destroyedmoon == 8f ||destroyedmoon == 6f)
        {
            level.text = "GREAT!\nDestroyed " + destroyedmoon + " Moonstones!";
            perfect_image.SetActive(false);
            excellent_image.SetActive(false);
            great_image.SetActive(true);
            qualified_image.SetActive(false);
            //failed_image.SetActive(false);
        }
        else if(destroyedmoon == 5f)
        {
            level.text = "QUALIFIED\nDestroyed " + destroyedmoon + " Moonstones!";
            perfect_image.SetActive(false);
            excellent_image.SetActive(false);
            great_image.SetActive(false);
            qualified_image.SetActive(true);
            //failed_image.SetActive(false);
        }
        else
        {
            level.text = "FAIL";
            failed_image.SetActive(true);
        }
    }
}
