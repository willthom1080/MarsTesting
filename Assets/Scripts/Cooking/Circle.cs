using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public bool heldDown;
    public float extent;
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
            Vector3 tempVect;
            tempVect = Camera.main.ScreenToWorldPoint(new Vector3(0, Input.mousePosition.y, 10));
            if ((!(Mathf.Abs(tempVect.y) > extent)))
            {
                transform.position = new Vector3(0, tempVect.y, tempVect.z);
            }
            if (Input.GetMouseButtonDown(0))
            {
                heldDown = true;
                
            }
            else if (Input.GetMouseButtonUp(0))
            {
                heldDown = false;
                transform.position = new Vector3(0, extent, 0);
            }
        }
    }
}
