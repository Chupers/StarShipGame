using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMovement : MonoBehaviour
{
    private const float RIGHTBORDER = 10f;
    private const float LEFTBORDER = -10f;

    public GameObject Player;
    public float speed = 2;
    float targetPost;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        Debug.Log(Player.transform.position.x);
        targetPost = Player.transform.position.x;
        Vector2 target = new Vector2(targetPost, gameObject.transform.position.y);
        gameObject.transform.position = Vector2.MoveTowards(gameObject.transform.position, target, step);

    }
}
