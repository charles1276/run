using Unity.VisualScripting;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public CheeseDeath cd;
    public CheeseDeath cd2;
    public CheeseDeath cd3;
    public CheeseDeath cd4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cd.died == true)
        {
            Destroy(player);
        }
        if (cd2.died == true)
        {
            Destroy(player);
        }
        if (cd3.died == true)
        {
            Destroy(player);
        }
        if (cd4.died == true)
        {
            Destroy(player);
        }


    }
}

   