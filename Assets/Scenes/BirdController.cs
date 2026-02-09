using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 6f;
    private Rigidbody2D rb;
    private bool isDead = false;
    private bool started = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetStarted(bool value)
    {
        started = value;
    }

    [System.Obsolete]
    void Update()
    {
        if (!started || isDead) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDead) return;
        isDead = true;
        GameManager.Instance.GameOver();
    }
}
