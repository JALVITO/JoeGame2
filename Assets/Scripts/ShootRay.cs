using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRay : MonoBehaviour
{

    public Rigidbody attractor;
    public Rigidbody repeller;
    RaycastHit hit;
    Ray rayo;

    Rigidbody clone;

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rayo.origin, rayo.direction*100, Color.red);
        rayo = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(rayo, out hit) && hit.collider.gameObject.tag == "wall"){

            Vector3 pos = new Vector3(hit.point.x, hit.point.y, hit.point.z-0.5f);
            
            if (Input.GetMouseButtonDown(0))
                clone = Instantiate(attractor, pos, hit.transform.rotation);
            if (Input.GetMouseButtonDown(1))
                clone = Instantiate(repeller, pos, hit.transform.rotation);
        }
    }
}
