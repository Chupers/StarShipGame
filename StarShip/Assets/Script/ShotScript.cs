using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    public GameObject ammo;
    public float reloadSpeed = 0.5f;
    bool CanShot;

    // Start is called before the first frame update
    void Start()
    {
        CanShot = true;
    }

    // Update is called once per frame
    void Update()
    {
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
