using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetize : MonoBehaviour
{

    [SerializeField] int force;

    void OnTriggerStay(Collider col){
        if (col.gameObject.tag == "bullet"){
            Vector3 dir = col.transform.position - transform.position;

            if (Statistics.fx == 1){
                col.gameObject.GetComponent<Rigidbody>().AddForce(dir*force/(Mathf.Pow(dir.magnitude,2)));
                //Debug.Log("Using Quadratic");
            }
            else if (Statistics.fx == 2){
                col.gameObject.GetComponent<Rigidbody>().AddForce(dir*force/(Mathf.Pow(dir.magnitude,3)));
                //Debug.Log("Using Cubic");
            }
            else if (Statistics.fx == 3){
                col.gameObject.GetComponent<Rigidbody>().AddForce(dir*force/dir.magnitude);
                //Debug.Log("Using Linear");
            }
        }
    }
}
