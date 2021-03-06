﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BOSSBotMovement : MonoBehaviour
{
    private const float RIGHTBORDER = 10f;
    private const float LEFTBORDER = -10f;

    private GameObject Player;
    public float speed = 2;
    float targetPost;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        float step = speed * Time.deltaTime;
        targetPost = Player.transform.position.x;
        Vector2 target = new Vector2(targetPost, gameObject.transform.position.y);
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, step);
    }
}
