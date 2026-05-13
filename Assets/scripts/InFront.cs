using System.Collections;
using UnityEngine;

public class InFront : MonoBehaviour
{
    private GameObject player1;
    private GameObject player2;
    private GameObject player3;
    private GameObject player4;
    public cameracontruller cameracontrller;
    public GameObject maincamera;
    private Rigidbody2D pr1;
    private Rigidbody2D pr2;
    private Rigidbody2D pr3;
    private Rigidbody2D pr4;
    public bool cn = false;
    public bool cj = false;
    public bool p1cj = false;
    public bool p2cj = false;
    public bool p3cj = false;
    public bool p4cj = false;
    public bool p1isfront = false;
    public bool p2isfront = false;
    public bool p3isfront = false;
    public bool p4isfront = false;
    
    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        pr1 = player1.GetComponent<Rigidbody2D>();
        pr2 = player2.GetComponent<Rigidbody2D>();
        pr3 = player3.GetComponent<Rigidbody2D>();
        pr4 = player4.GetComponent<Rigidbody2D>();
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        cameracontrller = maincamera.GetComponent<cameracontruller>();  
        
    }
    // Update is called once per frame
    void Update()
    {
        if (cj == true)
        {
            cn = false;
        }
        else if (cj == false)
        {
            cn = true;
        }

        if (cameracontrller == null)
            Debug.Log("cameracontrller is not null");
        if (player1 == null && p1cj ==false)
        {
            StartCoroutine(jointime());
            player1 = GameObject.Find("Player1");
            pr1 = player1.GetComponent<Rigidbody2D>();
            }
        if (player2 == null && p2cj ==false)
        {
            player2 = GameObject.Find("Player2");
            pr2 = player2.GetComponent<Rigidbody2D>();
           
        }
        if (player3 == null && p3cj == false) { 
            player3 = GameObject.Find("Player3");
            pr3 = player3.GetComponent<Rigidbody2D>();
            
        }
        if (player4 == null && p4cj == false) { 
            player4 = GameObject.Find("Player4");
            pr4 = player4.GetComponent<Rigidbody2D>();
            

        }

        if (player3 == null)
        {
            if (pr1.transform.position.x > pr2.transform.position.x)
            {
                p1isfront = true;
                p2isfront = false;
            }
            else if (pr2.position.x > pr1.position.x)
            {
                p2isfront = true;
                p1isfront = false;
            }


        }
        else if (player4 == null)
        {
            if (pr1.position.x > pr2.position.x && pr1.position.x > pr3.position.x)
            {
                p1isfront = true;
                p2isfront = false;
                p3isfront = false;
            }
            else if (pr2.position.x > pr1.position.x && pr2.position.x > pr3.position.x)
            {
                p2isfront = true;
                p1isfront = false;
                p3isfront = false;
            }
            else if (pr3.position.x > pr1.position.x && pr3.position.x > pr2.position.x)
            {
                p3isfront = true;
                p1isfront = false;
                p2isfront = false;
            }

        }
        else if (player4 != null)
        {

            if (pr1.position.x > pr2.position.x && pr1.position.x > pr3.position.x && pr1.position.x > pr4.position.x)
            {
                p1isfront = true;
                p2isfront = false;
                p3isfront = false;
                p4isfront = false;
            }
            else if (pr2.position.x > pr1.position.x && pr2.position.x > pr3.position.x && pr2.position.x > pr4.position.x)
            {
                p2isfront = true;
                p1isfront = false;
                p3isfront = false;
                p4isfront = false;
            }
            else if (pr3.position.x > pr1.position.x && pr3.position.x > pr2.position.x && pr3.position.x > pr4.position.x)
            {
                p3isfront = true;
                p1isfront = false;
                p2isfront = false;
                p4isfront = false;
            }
            else if (pr4.position.x > pr1.position.x && pr4.position.x > pr2.position.x && pr4.position.x > pr3.position.x)
            {
                p4isfront = true;
                p1isfront = false;
                p2isfront = false;
                p3isfront = false;
            }
        }

    }
    public IEnumerator jointime()
    {
        yield return new WaitForSeconds(15);
        cj = true;
       
        p1cj = true;
        p2cj = true;
        p3cj = true;
        p4cj = true;
    }
}
