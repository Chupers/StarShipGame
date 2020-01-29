using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotScript : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject ammo;
    public int scoreColvo = 0; //This I use in AmmoMovement to get score count by shot in Enemy
    public int PlayerHP = 3;   //This I use in BotAmmoMovement for helth spaceship
    public float reloadSpeed = 0.5f;
    bool CanShot;
    MoveControl startMove;
    DesctopMoveControl DesctopMove;
    void Start()
    {
        CanShot = true;
        startMove = FindObjectOfType<MoveControl>();
        DesctopMove = FindObjectOfType<DesctopMoveControl>();
    }
    void Update()
    {
        if(startMove._isMoving || DesctopMove._isMoving)
        if (CanShot)
            StartCoroutine(Shot());
        if (PlayerHP <= 0)
            GameOver.SetActive(true);
    }
    IEnumerator Shot()
    {
        Instantiate(ammo,gameObject.transform);
        CanShot = false;
        yield return new WaitForSeconds(reloadSpeed);
        CanShot = true;
    }
}
