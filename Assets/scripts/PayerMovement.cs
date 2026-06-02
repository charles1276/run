using System.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.InputSystem;

public class PayerMovement : MonoBehaviour
{
    //[SerializeField] private Animator animator;
    [SerializeField] private TrailRenderer tr;

    public Transform groundCheck;
    public GroundHeck groundHeck;
    public GameObject player;
        public float moveSpeed;
    public float jumpHeight = 35.0f;
    public float doubleJumpHeight = 30.0f;
    public float speed = 3.0f;
   
   
    public bool isgrounded;
    private bool canDoubleJump;
    private Rigidbody2D rb2d;
    private float _movement;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        TrailRenderer tr = GetComponent<TrailRenderer>();

        tr.emitting = false;
    }

    void Update()
    {
       

        if (groundHeck != null && groundHeck.isground == true) { isgrounded = true; }

        rb2d.linearVelocityX = _movement;
        moveSpeed = rb2d.linearVelocity.x;

        
        

        if (rb2d.linearVelocity.x > 0)
        {
            
            animator.SetInteger("walkdirection", +1);
            spriteRenderer.flipX = false;
        }
        else if (rb2d.linearVelocity.x < 0)
        {
            
            animator.SetInteger("walkdirection", +1);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetInteger("walkdirection", 0);
        }

       // animator.SetBool("isJumping", rb2d.linearVelocity.y != 0);
    }

    
    public void Move(InputAction.CallbackContext ctx)
    {
        _movement = ctx.ReadValue<Vector2>().x * speed;
        
    }
    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (isgrounded == true)
            {
                rb2d.linearVelocityY = jumpHeight;
                isgrounded = false;
                canDoubleJump = true;
            }
            else if (canDoubleJump == true)
            {
                rb2d.linearVelocityY = doubleJumpHeight;
                
                canDoubleJump = false;
            }

        }
    } 
}