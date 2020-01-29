using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesctopMoveControl : MonoBehaviour
{
    private const float RIGHTBORDER = 10f;
    private const float LEFTBORDER = -10f;

    public float speed = 8f;
    void Update()
    {
        float Y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float X = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        gameObject.transform.Translate(X, 0, 0);
        gameObject.transform.Translate(0, Y, 0);
    }
}
