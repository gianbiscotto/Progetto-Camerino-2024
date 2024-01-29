using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muovi : MonoBehaviour
{
    private Vector2 followSpot;
    public float speed;
    public float prospectiveScale;
    public float scaleRatio;

    // Start is called before the first frame update
    void Start()
    {
        followSpot = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Prospective();
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            followSpot = new Vector2(mousePosition.x, (float)(mousePosition.y + 0.5));
        }
        transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
    }
    private void Prospective()
    {
        Vector3 scale = transform.localScale;
        scale.x = prospectiveScale * (scaleRatio - transform.position.y);
        scale.y = prospectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;
    }
}
