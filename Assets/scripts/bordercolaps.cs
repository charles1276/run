using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class bordercolaps : MonoBehaviour
{
    
    public bool shrink =false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        br = gameObject.transform.GetChild(0).gameObject;
        bl = gameObject.transform.GetChild(1).gameObject;
        bb = gameObject.transform.GetChild(2).gameObject;
        bt = gameObject.transform.GetChild(3).gameObject;
        btr = bt.GetComponent<Rigidbody2D>();
        brr = br.GetComponent<Rigidbody2D>();   
        blr = bl.GetComponent<Rigidbody2D>();
        bbr = bb.GetComponent<Rigidbody2D>();
        StartCoroutine(Second());
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( shrink ==true )
        {           
            BorderShrink();
        }   
    }
    public  void BorderShrink() 
    {
        Vector2 bts = btr.transform.localScale;
        bts.y += 012.1f;
        Vector2 brs = brr.transform.localScale;
        brs.y += 012.1f;
        Vector2 bls = blr.transform.localScale;
        bls.y += 012.1f;
        Vector2 bbs = bbr.transform.localScale;
        bbs.y += 012.1f;
        
    }
    public IEnumerator Second()
    {
        yield return new WaitForSeconds(1);
        //yield return new WaitForSeconds(240);
        shrink = true;
    }
}
