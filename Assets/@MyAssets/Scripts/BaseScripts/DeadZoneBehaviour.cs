using UnityEngine;

public class DeadZoneBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<BallBehaviour>().ResetPosition();
    }
}
