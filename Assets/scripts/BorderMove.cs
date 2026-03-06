using UnityEngine;

public class BorderMove : MonoBehaviour
{
    private GameObject bt;
    private Camera mc;
    private Vector2 mcv;
    private Vector2 btV;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bt = GameObject.FindGameObjectWithTag("borders");
        mc = GameObject.Find("Main Camera").GetComponent<Camera>();
        btV = bt.transform.position;
        mcv = mc.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = bt.transform.position;

        if (btV.x < mcv.x)
        {
            currentPos.x = mcv.x;
            bt.transform.position = currentPos;
        }
        if (btV.x > mcv.x)
        {
            currentPos.x -= 0.01f;
            bt.transform.position = currentPos;
        }
        if (btV.y < mcv.y)
        {
            currentPos.y += 0.01f;
            bt.transform.position = currentPos;
        }
        if (btV.y > mcv.y)
        {
            currentPos.y -= 0.01f;
            bt.transform.position = currentPos;
        }
    }
}
