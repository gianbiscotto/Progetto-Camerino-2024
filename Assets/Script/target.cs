using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{

    private Vector2 followSpot;
    public float speed;
    public float prospectiveScale;
    public float scaleRatio;
    public Transform groupObjects;
    public float maxDistance = 5f;


    // Start is called before the first frame update
    void Start()
    {
        followSpot = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, groupObjects.position);
        groupObjects.gameObject.SetActive(distance < maxDistance);

        Prospective();
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            followSpot = new Vector2(mousePosition.x, mousePosition.y+1);
        }
        transform.position = Vector2.MoveTowards(transform.position, followSpot, Time.deltaTime * speed);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        followSpot = transform.position;
    }

    private void Prospective()
    {
        Vector3 scale = transform.localScale;
        scale.x = prospectiveScale * (scaleRatio - transform.position.y);
        scale.y = prospectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = scale;


    }
}
