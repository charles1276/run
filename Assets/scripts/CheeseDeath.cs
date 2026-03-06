using UnityEngine;

public class CheeseDeath : MonoBehaviour
{
    private GameObject p1;
    private GameObject p2;
    private GameObject p3;
    private GameObject p5;
    public bool died1 = false;
    public bool died2 = false;
    public bool died3 = false;
    public bool died4 = false;
    public camracontruller iF;
    private Camera mc;
    public void Start()
    {
        mc = Camera.main;
        iF = mc.GetComponent<camracontruller>();
        p1 = GameObject.Find("Player1");
        p2 = GameObject.Find("Player2");
        p3 = GameObject.Find("Player3");
     
        p5 = GameObject.Find("Player4");
        
    }
     public void Update()
    {
        if (p1 == null && died1 == false)
        {
            p1 = GameObject.Find("Player1");
        }
        if (p2 == null && died2 == false)
        {
            p2 = GameObject.Find("Player2");
        }
        if (p3 == null && died3 == false)
        {
            p3 = GameObject.Find("Player3");
        }
       
        if (p5 == null && died4 == false)
        {
            
            p5 = GameObject.Find("Player4");
           
        }
        
       
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == p1)
        {
            died1 = true;
        }
        else if (other.gameObject == p2)
        {
            died2 = true;
        }
        else if ( other.gameObject == p3)
        {
            died3 = true;
        }
        else if (other.gameObject == p5)
        {
            died4 = true;
        }
    }
}