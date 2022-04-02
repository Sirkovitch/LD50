using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float scoreValue;
    void Start()
    {
        scoreValue = 0;
    }

    void FixedUpdate()
    {
        scoreValue = scoreValue + 0.2f;
        this.GetComponent<Text>().text = Mathf.Floor(scoreValue).ToString();
    }

    public void onHitBounce()
    {
        scoreValue = scoreValue + 200;
    }
    public void onHitWall()
    {
        scoreValue = scoreValue -20;
    }
    public void onHitBird()
    {
        scoreValue = scoreValue -100;
    }
}
