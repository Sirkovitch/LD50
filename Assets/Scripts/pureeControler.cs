using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureeControler : MonoBehaviour
{
    private Rigidbody2D rB;
    private float maxVel = -20;
    private float lateralSpeed = 1;
    private score score;
    void Start()
    {
        rB = this.GetComponent<Rigidbody2D>();
        score = GameObject.Find("score").GetComponent<score>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            rB.AddForce(new Vector3(-lateralSpeed * Input.GetAxis("Horizontal") * Mathf.Clamp(Mathf.Abs(rB.velocity.y)*2,0,1), 0, 0), ForceMode2D.Impulse);
            rB.velocity = new Vector2(rB.velocity.x, Mathf.Max(rB.velocity.y, maxVel));

        }
        else
        {
            float velocityX = Mathf.Lerp(rB.velocity.x, 0, 0.05f);
            rB.velocity = new Vector2(velocityX, Mathf.Max(rB.velocity.y, maxVel));

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bounce")
        {
            score.onHitBounce();
        }
        if (collision.gameObject.tag == "Bird")
        {
            score.onHitBird();
        }
        if (collision.gameObject.tag == "Wall")
        {
            score.onHitWall();
        }

    }

    private void Update()
    {

    }
}
