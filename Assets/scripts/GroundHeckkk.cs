using JetBrains.Annotations;
using UnityEngine;

public class GroundHeck : MonoBehaviour
{
    public bool isground;
    public PayerMovement payerMovement;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
             payerMovement.isgrounded = true;
             isground = true;
        }
        else { isground = false; }

    }
}
