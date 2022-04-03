using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldManager : MonoBehaviour
{
    public GameObject[] LDbricks;
    public GameObject LDendBrick;

    public float brickHeight = 20;
    public int brickNumber = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i < brickNumber; i++)
        {
            GameObject LDbrick = LDbricks[Random.Range(0,LDbricks.Length)];
            Instantiate(LDbrick, new Vector3(0, -i * brickHeight, 0), Quaternion.identity);
        }
        Instantiate(LDendBrick, new Vector3(0, -(brickNumber) * brickHeight, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
