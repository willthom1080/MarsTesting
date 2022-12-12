using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovementS : MonoBehaviour
{
    public SceneBossS theBoss;

    public float theSpeed = 5f;
    public Transform movePoint;
    public int facing;

    public LayerMask theObstacles;
    public LayerMask theEvents;
    void Start()
    {
        movePoint.parent = null;
        facing = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, theSpeed * Time.deltaTime);
        if (transform.position == movePoint.position)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1)
            {
                if(!Physics2D.OverlapCircle(movePoint.position + new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f),.2f,theObstacles)){
                    movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                    facing = (int)Input.GetAxisRaw("Horizontal");
                }
            }
            else if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1)
            {
                if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f), .2f, theObstacles))
                {
                    movePoint.position += new Vector3(0f, Input.GetAxisRaw("Vertical"), 0f);
                    facing = (int)Input.GetAxisRaw("Vertical")*2;
                }
            }
        }

        if (Physics2D.OverlapCircle(transform.position, .2f, theEvents)){
            theBoss.onEvent(facing);
        }
    }

    private void FixedUpdate()
    {
        
    }
}
