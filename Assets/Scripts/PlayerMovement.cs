using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public bool isFacingRight = true;
    public Transform checkPoint;
    Rigidbody2D rb;
    public LayerMask ground;
    public Transform groundCheck;
    public bool canDash = true;
    public bool isDashing;
    private float dashingPower = 12f;
    private float dashingTime = 0.2f;
    public bool grounded = false;
    public Vector3 checkPointPos;
    private float dashNumber = 1f;
    [SerializeField] private TrailRenderer tr;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        checkPointPos = new Vector3(checkPoint.transform.position.x,checkPoint.transform.position.y,checkPoint.transform.position.z);
        transform.position = new Vector3(checkPoint.transform.position.x,checkPoint.transform.position.y,checkPoint.transform.position.z);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing){
            return;
        }

        Move();
        Jump();
        if (Input.GetKeyDown(KeyCode.LeftShift) && canDash && (dashNumber > 0))
        {
            SoundManager.PlaySound("DashSound");
            StartCoroutine(Dash());
            dashNumber -= 1;
        }
        Flip();
        if (!Physics2D.OverlapCircle(groundCheck.transform.position,0.3f,ground)){
            canDash = true;
            grounded = false;
        }
        if (Physics2D.OverlapCircle(groundCheck.transform.position,0.3f,ground)){
            canDash = false;
            grounded = true;
            dashNumber = 1f;
        }

    }
    void FixedUpdate(){
        if (isDashing){
            return;
        }
    }
    void Move(){
        transform.position = new Vector3(transform.position.x + HorizontalInput() * moveSpeed * Time.deltaTime,transform.position.y,transform.position.z);
    }
    void Jump(){
        if (Input.GetButtonDown("Jump") && grounded){
            SoundManager.PlaySound("JumpSound");
            rb.AddForce(new Vector2(0,jumpForce),ForceMode2D.Impulse);
        }
    }
    public float HorizontalInput(){
        return Input.GetAxis("Horizontal");
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        canDash = true;
    }
    private void Flip()
    {
        if (isFacingRight && HorizontalInput() < 0f || !isFacingRight && HorizontalInput() > 0f)
        {
            Vector3 localScale = transform.localScale;
            isFacingRight = !isFacingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
