using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed = 5;
    public float patrolWidth = 20;
    private bool directionSwitch;
    public bool randomSpeed = false;
    void Start()
    {
        patrolWidth = patrolWidth - 1.5f;
        int randInt = Random.Range(0, 2);
        if (randInt == 0)
        {
            directionSwitch = true;
        }
        else
        {
            directionSwitch = false;
        }
        if (randomSpeed == true)
        {
            float randFloat = Random.Range(0, 3)-1.5f;
            speed = speed + randFloat;

        }
    }

    void Update()
    {
        if (this.transform.position.x >= patrolWidth / 2)
        {
            directionSwitch = false;
        }
        if (this.transform.position.x <= -patrolWidth / 2)
        {
            directionSwitch = true;
        }
        if (directionSwitch == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed, Space.World);
            this.transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed, Space.World);
            this.transform.eulerAngles = new Vector3(0, 180, 90);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = GameObject.Find("Player");
        this.transform.parent = player.transform;
        Destroy(this.GetComponent<Rigidbody2D>());
        this.GetComponent<patrol>().enabled = false;

    }
}
