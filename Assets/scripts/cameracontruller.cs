using UnityEngine;

public class cameracontruller : MonoBehaviour
{
    public GameObject target;
    public InFront inf;
    public float speed =3f;
    public Vector3 offset;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        if (inf == null)
        {
            inf = this.gameObject.GetComponent<InFront>();


        }
    }

        // Update is called once per frame
    void Update()
    {
        if (inf.p1isfront == true)
        {
            target = GameObject.Find("Player1"); ;
        }
        else if (inf.p2isfront == true)
        {
            target = GameObject.Find("Player2"); ;
        }
        else if (inf.p3isfront == true)
        {
            target = GameObject.Find("Player3"); ;
        }
        else if (inf.p4isfront == true)
        { 
            target = GameObject.Find("Player4"); ;
        }
    }
    
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.fixedDeltaTime * speed);
    }
}

