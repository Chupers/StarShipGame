using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAmmoMovement : MonoBehaviour
{
    private GameObject oneHP;
    private GameObject twoHP;
    private GameObject threeHP;
    private GameObject playerSpaceShip;
    ShotScript shotScript;
    private void Start()
    {
        oneHP = GameObject.FindWithTag("1hp");
        twoHP = GameObject.FindWithTag("2hp");
        threeHP = GameObject.FindWithTag("3hp");
        playerSpaceShip = GameObject.FindWithTag("Player");
        shotScript = FindObjectOfType<ShotScript>();
    }
    void Update()
    {
        gameObject.transform.Translate(0,-0.5f,0);
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            Destroy(gameObject, 0.01f);
            shotScript.PlayerHP -= 1;
            if(shotScript.PlayerHP == 2)
                Destroy(threeHP, 0.1f);
            if (shotScript.PlayerHP == 1)
                Destroy(twoHP, 0.1f);
            if (shotScript.PlayerHP == 0)
            {
                Destroy(oneHP, 0.1f);
                Destroy(playerSpaceShip, 0.5f);
            }
        }
            
    }
}
