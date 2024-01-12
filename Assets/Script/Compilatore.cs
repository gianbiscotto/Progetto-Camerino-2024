using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Compilatore : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI testo;


    // Start is called before the first frame update
    void Start()
    {

        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Crea()
    {
        this.gameObject.SetActive(true);

    }

    public void Distruggi()
    {
        this.gameObject.SetActive(false);

    }
}