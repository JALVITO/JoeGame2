using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameRay : MonoBehaviour
{
    public Text ballLabel;
    public static int balls;
    public static int targets;

    // Start is called before the first frame update
    void Start()
    {
        targets = 0;
        balls = 50;
        ballLabel.text = "Marbles Left: " + balls;
    }

    // Update is called once per frame
    void Update()
    {
        if (balls <= 0){
            Statistics.balls = balls;
            //Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if (targets == 1){
            if (balls >= 40)
                Statistics.unlockedFunctions = true;
            StartCoroutine(waitVictory());
        }

        ballLabel.text = "Marbles Left: " + balls;
    }

    IEnumerator waitVictory(){
        yield return new WaitForSeconds(1.5F);
        Statistics.balls = balls;
        //Destroy(gameObject);
        SceneManager.LoadScene("Win");
    }
}
