using UnityEngine;

public class InFront : MonoBehaviour
{
    public cameracontruller cameracontrller;
    public GameObject maincamera;

    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        cameracontrller = maincamera.GetComponent<cameracontruller>();  
        cameracontrller.target = this.gameObject;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
