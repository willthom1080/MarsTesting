using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementS : MonoBehaviour
{
    Rigidbody2D body;

    Camera mainCam;

    float horizontal;
    float vertical;
    [SerializeField] float diagRatio;

    public float runSpeed;
    void Start()
    {
        mainCam = Camera.main;
        body = GetComponent<Rigidbody2D>();
        mainCam.transform.position = new Vector3(body.position.x, body.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Mathf.Abs(horizontal) > 0.001 || Mathf.Abs(vertical) > 0.001)
        {
            mainCam.transform.position = new Vector3(body.position.x, body.position.y, -10);
        }
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
