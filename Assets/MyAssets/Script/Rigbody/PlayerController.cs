using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]private float Health = 5;
    [SerializeField] private int HealthMax = 5;
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    public Image HealthBar;

    private Rigidbody2D rb;
    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        HealthMax = int.Parse(Health.ToString());
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        HealthBar.fillAmount = Health /  HealthMax;
        if (Health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}