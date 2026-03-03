using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class brs : MonoBehaviour
{
    public bordercolaps bcs;
    public Rigidbody2D brr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (brr == null) { brr = GetComponent<Rigidbody2D>(); }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bcs != null)
        {
            if (bcs.shrink == true)
            {
                if (brr.transform.localScale.x < 26.5f)
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
        
        Vector2 brs = brr.transform.localScale;
        brs.x += .0015f;
        brr.transform.localScale = brs;
        yield return null;
       
    }
}
