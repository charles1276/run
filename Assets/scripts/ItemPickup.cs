using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ItemPickup : MonoBehaviour
{
    private bool pickUpAllowed;
    public bool pickuped;
    public bool ispickedupbyp1;
    public bool ispickedupbyp2;
    public bool ispickedupbyp3;
    public bool ispickedupbyp4;

    public GameObject player;


    void Update()
    {
        
        if (pickUpAllowed)
        {
            PickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject;
            pickUpAllowed = false;
        }
    }

    private void PickUp()
    {
        
            
            if (player.name == "player1")
            {
                ispickedupbyp1 = true;
            }
            else if (player.name == "player2")
            {
                ispickedupbyp2 = true;
            }
            else if (player.name == "player3")
            {
                ispickedupbyp3 = true;
            }
            else if (player.name == "player4")
            {
                ispickedupbyp4 = true;
            }
            // Add item to inventory or player
             Debug.Log("Item picked up by " + player.name);
        Destroy(gameObject);
        
    }
}

