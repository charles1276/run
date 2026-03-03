using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class bls : MonoBehaviour
{    
    public bordercolaps bcs;
    public Rigidbody2D blr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (bcs != null)
        {
            if (bcs.shrink == true)
            {
                if (blr.transform.localScale.x < 25f)
                {
                    BorderShrink();
                }
               
            }
        }
    }
    public void BorderShrink()
    {
        StartCoroutine(BorderS());
    }
    public IEnumerator BorderS()
    {
       
        Vector2 bls = blr.transform.localScale;
        bls.x += .0015f;
        blr.transform.localScale = bls;
       yield return null;
       

    }
}
