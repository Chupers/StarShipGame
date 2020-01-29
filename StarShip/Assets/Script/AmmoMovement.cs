using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoMovement : MonoBehaviour
{
    ShotScript shotScript;
    public GameObject score;
    private void Start()
    {
        shotScript = FindObjectOfType<ShotScript>();
        score = GameObject.FindWithTag("Score");
    }
    void Update()
    {
        gameObject.transform.Translate(0, 0.5f, 0);
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Enemy")
        {
            Destroy(gameObject, 0.01f);
            shotScript.scoreColvo += 10;
            score.GetComponent<Text>().text = "Score: " + shotScript.scoreColvo.ToString();
        }
    }
}
