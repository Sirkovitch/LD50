using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    private gravityManager gravityManager;
    private float gravityDirection;
    public Transform camGuide;
    public Transform puree;

    // Start is called before the first frame update
    void Start()
    {
        gravityManager = GameObject.Find("GravityManager").GetComponent<gravityManager>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, camGuide.rotation, 0.05f);
        this.transform.position = Vector3.Lerp(this.transform.position, new Vector3(puree.transform.position.x, puree.transform.position.y, 15), 0.05f);
    }
}
