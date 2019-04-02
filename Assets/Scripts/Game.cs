using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Text pointsLabel;
    public Text timeLabel;
    public static int points;
    public float targetTime;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        pointsLabel.text = "Points: " + points;
        timeLabel.text = "Time Left: " + targetTime;
    }

    // Update is called once per frame
    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0){
            Statistics.points = points;
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

        if (points == 4){
            StartCoroutine(waitVictory());
        }

        pointsLabel.text = "Points: " + points;
        timeLabel.text = "Time Left: " + (int)targetTime;
    }

    IEnumerator waitVictory(){
        yield return new WaitForSeconds(1.5F);
        Statistics.points = points;
        Destroy(gameObject);
        SceneManager.LoadScene("Win");
    }
}
