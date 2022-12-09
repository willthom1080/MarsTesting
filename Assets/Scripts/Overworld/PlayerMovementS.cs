using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementS : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    [SerializeField] float diagRatio;

    public float runSpeed;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        if(horizontal != 0 && vertical != 0)
        {
            horizontal *= diagRatio;
            vertical *= diagRatio;
        }
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
