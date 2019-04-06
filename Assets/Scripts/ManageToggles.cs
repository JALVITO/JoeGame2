using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageToggles : MonoBehaviour
{

    private Toggle m_Toggle;

    // Start is called before the first frame update
    void Start()
    {
        m_Toggle = GetComponent<Toggle>();
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });
        Statistics.fx = 1;
    }

    void Update(){
        if (gameObject.name == "BigBulletToggle"){
            m_Toggle.isOn = Statistics.bigBullets;
        }
    }

    void ToggleValueChanged(Toggle change)
    {
        if (gameObject.name == "BigBulletToggle")
            Statistics.bigBullets = m_Toggle.isOn;
        else if (gameObject.name == "FxToggle1")
            Statistics.fx = 1;
        else if (gameObject.name == "FxToggle2")
            Statistics.fx = 2;
        else if (gameObject.name == "FxToggle3")
            Statistics.fx = 3;
    }
}
