using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CantJoin : MonoBehaviour
{
    public PlayerInputManager pim;
    public camracontruller inFront;
    public GameObject mc;
    public PlayerLocation pl;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mc = GameObject.FindGameObjectWithTag("MainCamera");
        inFront = mc.GetComponent<camracontruller>();
        if (pim == null)
        {
            pim = GetComponent<PlayerInputManager>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inFront.cj == true)
        {
            pim.DisableJoining();
            pim.gameObject.SetActive(false);
            pl.enabled = false;
            
        }
    }

   
}
