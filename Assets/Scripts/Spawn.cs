using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Rigidbody marble;

    Rigidbody clone;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn(){
        while(true){
        clone = Instantiate(marble, transform.position,transform.rotation);
        GameRay.balls--;
        yield return new WaitForSeconds(3);
        }
    }
}
