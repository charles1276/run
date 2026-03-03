using UnityEngine;

public class PlayerLocation : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public Vector2 location;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        location = rb2d.position;
    }
}
