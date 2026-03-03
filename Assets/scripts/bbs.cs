using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class bbs : MonoBehaviour
{
    public bordercolaps bcs;
    public Rigidbody2D bbr;
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
                if (bbr.transform.localScale.y < 8f)
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
        
        Vector2 bbs = bbr.transform.localScale;
        bbs.y += .0002f;
        bbr.transform.localScale = bbs;
        yield return null;
        
       
    }
}
