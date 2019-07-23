using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cue : MonoBehaviour
{
    public GameObject ball;
    private float temps;
    private Vector2 mousePos;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        temps = Time.fixedTime;
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mousePos.x - 2, mousePos.y -2);
        if (!Input.GetMouseButtonDown(0))
        {
            Vector3 targ = ball.transform.position;
            targ.z = 0f;

            Vector3 objectPos = transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;

            float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg + 90;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }


    }
}
