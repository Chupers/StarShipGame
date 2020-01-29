using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotShotScript : MonoBehaviour
{
    public GameObject ammo;
    public float reloadSpeed = 0.5f;
    bool CanShot;
    void Start()
    {
        CanShot = true;
    }
    void Update()
    {
        if (CanShot)
            StartCoroutine(Shot());
    }
    IEnumerator Shot()
    {
        Instantiate(ammo, gameObject.transform);
        CanShot = false;
        yield return new WaitForSeconds(reloadSpeed);
        CanShot = true;
    }
}
