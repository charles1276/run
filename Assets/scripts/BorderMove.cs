using UnityEngine;

public class BorderMove : MonoBehaviour
{
    public GameObject targets;
    public camracontruller inf;
    public float speed = 3f;
    public Vector3 offset;
    public cameracontruller cc;
    private Camera mc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mc = GetComponent<Camera>();

        if (cc == null)
        {
            cc = mc.GetComponent<cameracontruller>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if cc.
        cc.target = targets;
    }

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targets.transform.position + offset, Time.fixedDeltaTime * speed);
    }
}