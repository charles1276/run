using UnityEngine;

public class CheeseDeath : MonoBehaviour
{
    public bool died = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            died = true;
        }
    }
}