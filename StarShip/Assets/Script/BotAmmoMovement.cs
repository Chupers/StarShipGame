using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAmmoMovement : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Translate(0,-0.5f,0);
        Destroy(gameObject, 3f);
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
            Destroy(gameObject, 0.01f);
    }
}
