using JetBrains.Annotations;
using UnityEngine;

public class GroundHeck : MonoBehaviour
{
    public bool isground;
    public PayerMovement payerMovement;
   
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            payerMovement.isgrounded = true;
            isground = true;
        }

    }
   
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            payerMovement.isgrounded = false;
            isground = false;
        }
    }
}
