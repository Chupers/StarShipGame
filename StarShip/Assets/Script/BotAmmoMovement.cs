using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotAmmoMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0,-0.5f,0);
    }
}
