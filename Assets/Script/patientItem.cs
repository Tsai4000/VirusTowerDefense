﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patientItem : MonoBehaviour
{
    public int HP = 10;
    public int Energy = 0;
    private int attributes = 1;
    private float fSec = 10;
    private float fMoveTmp = 0;
    private bool isMove = false;
    Animator anima;

    // Start is called before the first frame update
    void Start()
    {
        anima = gameObject.GetComponent<Animator>();

    }

    public void Go() {
        isMove = true;
    }

    void DestroySelf()
    {
        gameManager.Instance.addIEnergy(Energy);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0) {
            gameObject.tag = "Repaired";
            anima.SetTrigger("heal");
            Invoke("DestroySelf", 0.95f);
        }
        // 移動腳本改由patientMovement.cs處理
        // if(isMove == true) {
        //     transform.Translate((new Vector3(0, transform.position.y, 0) - transform.position) * Time.deltaTime * fSec);
        //     fMoveTmp += (1f / fSec) * Time.deltaTime;

        //     transform.position = Vector3.Lerp(new Vector3(1600, transform.position.y,0), new Vector3(0, transform.position.y, 0), fMoveTmp);
        // }
        // if(fMoveTmp >= 1) {
        //     isMove = false;
        //     fMoveTmp = 0;
        // }

    }
}
