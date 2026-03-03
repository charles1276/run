using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class bts : MonoBehaviour
{
    public bordercolaps bcs;
    public Rigidbody2D btr;
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
                if (btr.transform.localScale.y < 7.2f)
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
        Vector2 bts = btr.transform.localScale;
        bts.y += .0002f;
        btr.transform.localScale = bts;
        yield return null;
        

    }
}
