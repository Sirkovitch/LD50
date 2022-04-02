using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureeControler : MonoBehaviour
{
    private Rigidbody2D rB;
    private float maxVel = -10;
    private float lateralSpeed = 1;
    void Start()
    {
        rB = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            rB.AddForce(new Vector3(-lateralSpeed * Input.GetAxis("Horizontal") * Mathf.Clamp(Mathf.Abs(rB.velocity.y)*10,0,1), 0, 0), ForceMode2D.Impulse);
            rB.velocity = new Vector2(rB.velocity.x, Mathf.Max(rB.velocity.y, maxVel));

        }
        else
        {
            float velocityX = Mathf.Lerp(rB.velocity.x, 0, 0.05f);
            //rB.velocity = new Vector2(velocityX, Mathf.Max(rB.velocity.y, maxVel));

        }

    }

    private void Update()
    {

    }
}
