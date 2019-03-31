using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoundaryCheck : MonoBehaviour
{
    void OnTriggerExit(Collider col){
        if (col.gameObject.tag == "Player"){
            Statistics.points = Game.points;
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
