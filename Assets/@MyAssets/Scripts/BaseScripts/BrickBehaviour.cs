using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
    
}
