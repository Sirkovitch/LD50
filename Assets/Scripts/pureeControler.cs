using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pureeControler : MonoBehaviour
{
    private Rigidbody rB;
    private float maxVel = -20;
    private float lateralSpeed = 20;
    private score score;
    private bool direction;
    private bool collided = false;
    private float collisionMalus = 1;
    public GameObject pureeDecal;

    void Start()
    {
        rB = this.GetComponent<Rigidbody>();
        score = GameObject.Find("score").GetComponent<score>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 )
        {  
            Vector3 inputVelocity = new Vector3(-lateralSpeed * Input.GetAxis("Horizontal"), Mathf.Max(rB.velocity.y, maxVel), 0);
            rB.velocity = Vector3.Lerp(rB.velocity, inputVelocity, collisionMalus);
        }
        else
        {
            float velocityX = Mathf.Lerp(rB.velocity.x, 0, 0.02f);
            rB.velocity = new Vector3(velocityX, Mathf.Max(rB.velocity.y, maxVel),0);

        }
        if (Input.GetAxis("Horizontal") > 0 && direction == false || Input.GetAxis("Horizontal") < 0 && direction == true)
        {
            //rB.velocity = new Vector3(0, Mathf.Max(rB.velocity.y, maxVel), 0);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction = true;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            direction = false;
        }
        collisionMalus = Mathf.Lerp(collisionMalus, 1, 0.002f);

    }

    private void OnCollisionEnter(Collision collision)
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
            StartCoroutine(WallCollision());
            GameObject decal = Instantiate(pureeDecal, collision.contacts[0].point, Quaternion.LookRotation(-collision.contacts[0].normal));
            decal.transform.localScale = Vector3.Lerp(new Vector3(5, 5, 5), new Vector3(2, 2, 2), Random.Range(0.0f, 1.0f));
            decal.transform.localEulerAngles = new Vector3(decal.transform.localEulerAngles.x, decal.transform.localEulerAngles.y, Random.Range(0, 360));
        }

    }

    IEnumerator WallCollision()
    {
        collided = true;
        collisionMalus = 0;
        yield return new WaitForSeconds(0.5f);
        collided = false;
    }

    private void Update()
    {

    }
}
