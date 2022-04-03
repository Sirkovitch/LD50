using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityManager : MonoBehaviour
{
    public float gravityDirection = 0;
    public Transform camGuide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Right"))
        {
            gravityDirection = gravityDirection + 90;
            camGuide.Rotate(new Vector3(0, 0, -90));
        }
        if (Input.GetButtonDown("Left"))
        {
            gravityDirection = gravityDirection - 90;
            camGuide.Rotate(new Vector3(0, 0, 90));
        }
    }

}
