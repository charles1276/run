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
       
        StartCoroutine(Second());
    }

   
    public IEnumerator Second()
    {
       yield return new WaitForSeconds(1);
        //yield return new WaitForSeconds(240);
        shrink = true;
       
    }
}
