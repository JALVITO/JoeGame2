using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetize : MonoBehaviour
{

    [SerializeField] int force;

    void OnTriggerStay(Collider col){
        if (col.gameObject.tag == "bullet"){
            Vector3 dir = col.transform.position - transform.position;
            col.gameObject.GetComponent<Rigidbody>().AddForce(dir*force/(Mathf.Pow(dir.magnitude,2)));
        }
    }
}
