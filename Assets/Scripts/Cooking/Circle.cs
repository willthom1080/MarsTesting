using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public bool heldDown;
    private void OnMouseDown()
    {
        heldDown = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (heldDown)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 8));
            if (Input.GetMouseButtonDown(0))
            {
                heldDown = true;
                
            }
            else if (Input.GetMouseButtonUp(0))
            {
                heldDown = false;
            }
        }
    }
}
