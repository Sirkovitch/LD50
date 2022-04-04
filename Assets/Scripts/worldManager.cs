using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class worldManager : MonoBehaviour
{
    public GameObject[] LDbricks;
    public GameObject LDendBrick;
    public GameObject player;
    public GameObject score;
    public GameObject[] title;


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

        StartCoroutine(startFlow());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("space") == true)
        {
            SceneManager.LoadScene("MainScene");
        }
    }

    private IEnumerator startFlow()
    {
        yield return new WaitForSeconds(1);

        title[0].gameObject.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        title[1].gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);

        title[2].gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        title[3].gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        title[4].gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        title[5].gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);

        title[6].gameObject.SetActive(true);
        yield return new WaitForSeconds(3);
        title[0].gameObject.SetActive(false);
        title[1].gameObject.SetActive(false);
        title[2].gameObject.SetActive(false);
        title[3].gameObject.SetActive(false);
        title[4].gameObject.SetActive(false);
        title[5].gameObject.SetActive(false);
        title[6].gameObject.SetActive(false);

        yield return new WaitForSeconds(.05f);
        player.SetActive(true);
        score.SetActive(true);
    }
}
