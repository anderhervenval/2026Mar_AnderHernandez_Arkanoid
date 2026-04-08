using System;
using System.Collections.Specialized;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float linearSpeed = 1.0f;

    public Vector2 startDirection = Vector2.zero;


    Rigidbody2D _rb2d;

    private Vector2 startPosition;

    internal void ResetPosition()
    {
        transform.position = startPosition;
        _rb2d.linearVelocity = startDirection.normalized * linearSpeed;
    }

    private void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        _rb2d.linearVelocity = startDirection.normalized * linearSpeed;
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //_rb2d.linearVelocity = _rb2d.linearVelocity.normalized * linearSpeed;
    }
}
