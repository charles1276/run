using UnityEngine;

public class cameracontruller : MonoBehaviour
{
    public GameObject target;

    public float speed =3f;
    public Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, Time.fixedDeltaTime * speed);
    }
}

