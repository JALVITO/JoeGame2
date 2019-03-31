using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetBreak : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        Debug.Log("colliding");
        if (col.gameObject.tag == "bullet"){
            GetComponent<AudioSource>().Play();
            if (SceneManager.GetActiveScene().name == "ProjectileShooting")
                Game.points++;
            else
                GameRay.targets++;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
    }

}
