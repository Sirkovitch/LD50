using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform puree;
    public bool followX;


    void Start()
    {

    }


    void LateUpdate()
    {
        if (followX == true)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(puree.transform.position.x, puree.transform.position.y+1, 20), 0.02f);

        }
        else
        {
            this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(0, puree.transform.position.y+1, 20), 0.2f);

        }
    }
}
