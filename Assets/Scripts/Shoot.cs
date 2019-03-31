using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public Rigidbody bala;
	public int speed;
	Rigidbody clone;
    bool allowFire;

    void Start(){
        allowFire = true;
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && (allowFire)){
        	StartCoroutine(fire());
        }
    }

    IEnumerator fire(){
        allowFire = false;
        clone = Instantiate(bala, transform.position,transform.rotation);
        clone.velocity = transform.TransformDirection(0,0,speed);
        Destroy(clone.gameObject,3);
        yield return new WaitForSeconds(0.05F);
        allowFire = true;
    }
}
