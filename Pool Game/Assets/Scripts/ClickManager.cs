using System;
using UnityEngine;
using System.Collections;


public class ClickManager : MonoBehaviour
{

    public GameObject ball;
    private Rigidbody2D rb2d;
    private Transform target;
    private float temps;
    private Vector2 mousePos;

    void Start()
    {
        rb2d = ball.GetComponent<Rigidbody2D>();
        target = ball.GetComponent<Transform>();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            temps = Time.fixedTime;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector2(transform.position.x - mousePos.x, transform.position.y - mousePos.y);
            //Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            //RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            //if (hit.collider != null)
            //{
            //    Debug.Log(hit.collider.gameObject.name);
            //    hit.collider.attachedRigidbody.AddForce(Vector2.up);
            //}

        }
        if (Input.GetMouseButtonUp(0) && Time.fixedTime - temps < 1)
        {
            rb2d.AddForce(mousePos * 5);
            //target.position = Vector2.MoveTowards(target.position, mousePos, 5 * Time.deltaTime);
        }
        if (Input.GetMouseButtonUp(0) && Time.fixedTime - temps < 2)
        {
            rb2d.AddForce(mousePos * 10);
            //target.position = Vector2.MoveTowards(target.position, mousePos, 5 * Time.deltaTime);
        }

    }
}