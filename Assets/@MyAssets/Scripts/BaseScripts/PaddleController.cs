using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    [SerializeField]private Rigidbody2D rb;


    [SerializeField] float paddleSpeed;
   

    [SerializeField] private InputActionReference moveAction;
    [SerializeField] private InputActionReference launchBall;
    private Vector2 moveInput;
    private bool wantToLaunchBall;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void OnEnable()
    {
        moveAction.action.Enable();
    }
    private void OnDisable()
    {
        moveAction.action.Disable();
    }
    // Update is called once per frame
    void Update()
    {
       UpdateInput();
    }


    public void UpdateInput() { 

        moveInput = moveAction.action.ReadValue<Vector2>();
        wantToLaunchBall = launchBall.action.ReadValue<bool>();
        rb.linearVelocityX = moveInput.x * paddleSpeed;
    
    }


    private void OnTriggerEnter(Collider other)
    {
        
    }
}
