using System;
using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    private GameObject player;
    public InFront inFront;
    private Camera mc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mc = Camera.main;
        player = this.gameObject;
        inFront = mc.GetComponent<InFront>();

    }

    // Update is called once per frame
    void Update()
    {
            
        
        if (player.name != "Player1")
        {
            if (GameObject.Find("Player1") == null)
            {
                if (inFront.cn == true)
                    player.name = "Player1";
            }

            else if (player.name != "Player2")
            {
                if (GameObject.Find("Player2") == null)
                {
                    if (inFront.cn == true)
                        player.name = "Player2";
                }


                else if (player.name != "Player3")
                {
                    if (GameObject.Find("Player3") == null)
                    {
                        if (inFront.cn == true)
                            player.name = "Player3";
                    }


                    else if (player.name != "Player4")
                    {
                        if (GameObject.Find("Player4") == null)
                        {
                            if (inFront.cn == true)
                                player.name = "Player4";
                        }

                    }

                }

            }
        }

    }
}
