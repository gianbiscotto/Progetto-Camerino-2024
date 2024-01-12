using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Porta : MonoBehaviour
{
    public Compilatore compilatore;
    private SpriteRenderer spriteRenderer;
    public TMP_Dropdown TMP_Dropdown;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (TMP_Dropdown.value == 0)
        {
            spriteRenderer.color = Color.red;
        }
        else
        {
            spriteRenderer.color = Color.green;
        }
    }

    private void OnMouseDown()
    {
        compilatore.Crea();
    }
}
