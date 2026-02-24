using UnityEngine;

public class GroundHeck : MonoBehaviour
{

    public PayerMovement payerMovement;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
             payerMovement.isgrounded = true;
        }

    }
}
