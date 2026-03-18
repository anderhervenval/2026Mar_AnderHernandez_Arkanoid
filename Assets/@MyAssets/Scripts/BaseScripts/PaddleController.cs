using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;

    [SerializeField] private bool goLeft;
    [SerializeField] private bool goRight;



    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        goLeft = false;
        goRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (goLeft)
        {
            rb.linearVelocityX = -3f;
        }
        else if (goRight)
        {
            rb.linearVelocityX = 3f;
        }
        else {
            rb.linearVelocityX = 0f;
        }
    }
}
