using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotScript : MonoBehaviour
{
    public GameObject ammo;
    public int scoreColvo = 0; //This i use in AmmoMovement to get score count by shot in Enemy
    public float reloadSpeed = 0.5f;
    bool CanShot;
    MoveControl startMove;
    void Start()
    {
        CanShot = true;
        startMove = FindObjectOfType<MoveControl>();
    }
    void Update()
    {
        if(startMove._isMoving)
        if (CanShot)
            StartCoroutine(Shot());
    }
    IEnumerator Shot()
    {
        Instantiate(ammo,gameObject.transform);
        CanShot = false;
        yield return new WaitForSeconds(reloadSpeed);
        CanShot = true;
    }
}
