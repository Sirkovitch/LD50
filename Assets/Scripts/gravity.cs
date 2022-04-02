using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private gravityManager gravityManager;
    private float gravityDirection;
    public bool gravitySnap;

    // Start is called before the first frame update
    void Start()
    {
        gravityManager = GameObject.Find("GravityManager").GetComponent<gravityManager>();
    }

    // Update is called once per frame
    void Update()
    {
        gravityDirection = gravityManager.gravityDirection;
        this.GetComponent<Rigidbody2D>().AddForce(Quaternion.Euler(0, 0, gravityDirection) * new Vector3(0,-10,0), ForceMode2D.Force);
        if (Input.GetButtonDown("Right") && gravitySnap == true || Input.GetButtonDown("Left") && gravitySnap == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector3(0,0,0);
        }

    }

}
