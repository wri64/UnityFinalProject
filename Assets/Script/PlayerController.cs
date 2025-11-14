using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[Header("Horizontal Movement Setting")]
	[SerializeField] private Rigidbody2D rb;


	[SerializeField] private float walkSpeed = 1;

    private float xAxis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        Move();
    }

    void GetInput()
    {
          xAxis = Input.GetAxisRaw("Horizontal");
    }
    private void Move()
    {
        rb.linearVelocity = new Vector2(walkSpeed * xAxis, rb.linearVelocity.y);
    }
}
