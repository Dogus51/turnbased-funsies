using UnityEngine;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    private RaycastHit2D[] hitBuffer = new RaycastHit2D[5];
    private ContactFilter2D contactFilter;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        contactFilter = new ContactFilter2D();
        contactFilter.useTriggers = false;
        contactFilter.SetLayerMask(Physics2D.GetLayerCollisionMask(gameObject.layer));
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 move = movement.normalized * moveSpeed * Time.fixedDeltaTime;

        Vector2 newPosition = rb.position;

        // Check X movement
        Vector2 moveX = new Vector2(move.x, 0);
        if (rb.Cast(moveX, contactFilter, hitBuffer, Mathf.Abs(moveX.x)) == 0)
        {
            newPosition.x += moveX.x;
        }

        // Check Y movement
        Vector2 moveY = new Vector2(0, move.y);
        if (rb.Cast(moveY, contactFilter, hitBuffer, Mathf.Abs(moveY.y)) == 0)
        {
            newPosition.y += moveY.y;
        }

        rb.MovePosition(newPosition);
    }
}
