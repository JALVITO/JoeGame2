using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootRay : MonoBehaviour
{

    public Rigidbody attractor;
    public Rigidbody repeller;
    public Text attractorLabel;
    public Text repellerLabel;
    RaycastHit hit;
    Ray rayo;
    int fireMode;
    int attractorCount;
    int repellerCount;

    Rigidbody clone;

    void Start(){
        fireMode = 1;
        attractorCount = 3;
        repellerCount = 3;

        attractorLabel.text = attractorCount.ToString();
        repellerLabel.text = repellerCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1")){
            fireMode = 1;
        }
        if (Input.GetKeyDown("2")){
            fireMode = 2;
        }
        if (Input.GetKeyDown("3")){
            fireMode = 3;
        }

        attractorLabel.text = attractorCount.ToString();
        repellerLabel.text = repellerCount.ToString();

        Debug.DrawRay(rayo.origin, rayo.direction*100, Color.red);
        rayo = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(rayo, out hit) && hit.collider.gameObject.tag == "wall"){

            Vector3 pos = new Vector3(hit.point.x, hit.point.y, hit.point.z-0.5f);
            if (Input.GetMouseButtonDown(0)){
                if (fireMode == 1 && attractorCount > 0){
                    clone = Instantiate(attractor, pos, hit.transform.rotation);
                    attractorCount--;
                }
                else if (fireMode == 2 && repellerCount > 0){
                    clone = Instantiate(repeller, pos, hit.transform.rotation);
                    repellerCount--;
                }
            }
        }

        int layerMask = 1 << 2;
        if (Physics.Raycast(rayo, out hit, Mathf.Infinity, layerMask) && hit.collider.gameObject.tag == "magnet" && fireMode == 3 && Input.GetMouseButtonDown(0)){
            //Debug.Log("colliding with " + hit.collider.gameObject.tag);
            if (hit.collider.gameObject.name == "Attractor(Clone)")
                attractorCount++;
            if (hit.collider.gameObject.name == "Repeller(Clone)")
                repellerCount++;

            Destroy(hit.collider.gameObject);
        }
    }
}
