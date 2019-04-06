using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetBreak : MonoBehaviour
{

    public GameObject marbleSpawner;

    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "bullet"){
            GetComponent<AudioSource>().Play();
            if (SceneManager.GetActiveScene().name == "ProyectileShooting"){
                if (gameObject.name == "HiddenTarget")
                    Statistics.shotSecretTarget = true;
                else
                    Game.points++;

            }
            else{
                GameRay.targets++;
                marbleSpawner.SetActive(false);
            }
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
        }
    }

}
