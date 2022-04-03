using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float scoreValue;
    private float nastyScore = 0;
    private float birdCount = 0;
    private float bounceCount = 0;

    void Start()
    {
        scoreValue = 0;
    }

    void FixedUpdate()
    {
        scoreValue = Mathf.Abs(scoreValue) + 0.2f;
        this.GetComponent<Text>().text = Mathf.Floor(scoreValue).ToString();
    }

    public void onHitBounce()
    {
        scoreValue = scoreValue + 200;
        bounceCount += 1;
    }
    public void onHitWall()
    {
        scoreValue = scoreValue -20;
    }
    public void onHitBird()
    {
        scoreValue = scoreValue -100;
        nastyScore += 1;
        birdCount += 1;
    }
}
