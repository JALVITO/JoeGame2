using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EasterEggToggle : MonoBehaviour
{

    public GameObject toggle;

    public GameObject toggleFunctions;


    // Start is called before the first frame update
    void Start()
    {
        toggle.SetActive(false);
        toggleFunctions.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Statistics.shotSecretTarget)
            toggle.SetActive(true);

        if (Statistics.unlockedFunctions)
            toggleFunctions.SetActive(true);
    }
}
