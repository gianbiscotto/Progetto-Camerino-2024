using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class porta : MonoBehaviour
{
    public TMP_Dropdown TMP_Dropdown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (TMP_Dropdown.value == 1)
        {
            //go next scene
        }
    }
}
