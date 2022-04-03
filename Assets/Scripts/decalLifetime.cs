using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decalLifetime : MonoBehaviour
{
    private float alpha = 1;
    void Start()
    {
        
    }

    void Update()
    {
        alpha = Mathf.Lerp(alpha, 0, 0.002f);
        this.GetComponent<Renderer>().material.SetColor("_Color", new Vector4(1, .35f, 0, alpha));
        if(alpha < 0.01)
        {
            Destroy(this.gameObject);
        }
    }
}
