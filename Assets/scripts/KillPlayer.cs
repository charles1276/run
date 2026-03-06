using Unity.VisualScripting;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    private GameObject p1;
    private GameObject p2;
    private GameObject p3;
   
    private GameObject p4;
    private GameObject bt;
    private GameObject bt2;
    private GameObject bt3;
    private GameObject bt4;
    private CheeseDeath cd;
    private CheeseDeath cd2;
    private CheeseDeath cd3;
    private CheeseDeath cd4;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        p1 = GameObject.Find("Player1");
        p2 = GameObject.Find("Player2");
        p3 = GameObject.Find("Player3");
       
        p4 = GameObject.Find("Player4");
        bt = GameObject.FindGameObjectWithTag("border");
        bt2 = GameObject.FindGameObjectWithTag("border2");
        bt3 = GameObject.FindGameObjectWithTag("border3");
        bt4 = GameObject.FindGameObjectWithTag("border4");
        cd = bt.GetComponent<CheeseDeath>();
        cd2 = bt2.GetComponent<CheeseDeath>();
        cd3 = bt3.GetComponent<CheeseDeath>();
        cd4 = bt4.GetComponent<CheeseDeath>();
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (p1 == null && cd.died1 ==false)
        {
            p1 = GameObject.Find("Player1");
        }
        if (p2 == null && cd.died2 == false)
        {
            p2 = GameObject.Find("Player2");
        }
        if (p3 == null && cd.died3 ==false)
        {
            p3 = GameObject.Find("Player3");
        }
        if (p4 == null && cd.died4 == false)
        {
           
            p4 = GameObject.Find("Player4");
            
        }
        if (player == p1)
        {
            if (cd.died1 == true)
            {
                Destroy(player);
            }
            else if (cd2.died1 == true)
            {
                Destroy(player);
            }
            else if (cd3.died1 == true)
            {
                Destroy(player);
            }
            else if (cd4.died1 == true)
            {
                Destroy(player);
            }
        }
        else if (player == p2)
        {
            if (cd.died2 == true)
            {
                Destroy(player);
            }
            else if (cd2.died2 == true)
            {
                Destroy(player);
            }
            else if (cd3.died2 == true)
            {
                Destroy(player);
            }
            else if (cd4.died2 == true)
            {
                Destroy(player);
            }
        }
        else if (player == p3)
        {        
            if (cd.died3 == true)
            {
                Destroy(player);
            }
            else if (cd2.died3 == true)
            {
                Destroy(player);
            }
            else if (cd3.died3 == true)
            {
                Destroy(player);
            }
            else if (cd4.died3 == true)
            {
                Destroy(player);
            }
         }
        else if (player == p4)
        {
            if (cd.died4 == true)
            {
                Destroy(player);
            }
            else if (cd2.died4 == true)
            {
                Destroy(player);
            }
            else if (cd3.died4 == true)
            {
                Destroy(player);
            }
            else if (cd4.died4 == true)
            {
                Destroy(player);
            }
        }
        
    }
   
    
    
}


   