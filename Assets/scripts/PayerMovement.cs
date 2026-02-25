using System.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.InputSystem;

public class PayerMovement : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public Transform groundCheck;
    public GroundHeck groundHeck;
    private GameObject player;
    public float moveSpeed;
    public float jumpHeight = 200.0f;
    public float speed = 3.0f;
    private float dashSpeed = 40f;
    private float dashTime = 0.2f;
    private float dashCooldown = 1f;
    private bool canDash = true;
    private bool isDashing = false;
    public bool isgrounded;
    private bool canDoubleJump;
    private Rigidbody2D rb2d;
    private float _movement;
   
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
          if (groundHeck != null && groundHeck.isground == true) { isgrounded = true; }

        rb2d.linearVelocityX = _movement;

        if (!isDashing)
        {
            rb2d.linearVelocity = new Vector2(_movement, rb2d.linearVelocity.y);
        }

        if (rb2d.linearVelocity.x > 0)
        {
            animator.SetInteger("walkdirction", +1);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (rb2d.linearVelocity.x < 0)
        {
            animator.SetInteger("walkdirction", -1);
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            animator.SetInteger("walkdirction", 0);
        }

        animator.SetBool("isJumping", rb2d.linearVelocity.y != 0);
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
                rb2d.linearVelocityY = jumpHeight;
                canDoubleJump = false;
            }

        }
    }
    public void Dash(InputAction.CallbackContext ctx)
    {
        if (canDash)
        {
            StartCoroutine(Dash());
        }
    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb2d.gravityScale;
        rb2d.gravityScale = 0;

        float dashDir = _movement != 0 ? Mathf.Sign(_movement) : 1f;
        rb2d.linearVelocity = new Vector2(dashDir * dashSpeed, 0);

        yield return new WaitForSeconds(dashTime);

        rb2d.gravityScale = originalGravity;
        isDashing = false;

        yield return new WaitForSeconds(dashCooldown);
        canDash = true;


    }
    
    // Add this method to detect landing on the ground
   
}