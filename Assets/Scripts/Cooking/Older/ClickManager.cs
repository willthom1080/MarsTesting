using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public enum clickMode
    {
        clickOn,
        circleOn
    }
    bool heldDown;

    clickMode theMode;
    // Start is called before the first frame update
    void Start()
    {
        heldDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Converts click position to world space whatever that means
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero); //Vector2.zero ensures only objects directly located are detected apparently

            if(theMode == clickMode.circleOn)
            {
                if(hit.collider != null)
                {
                    GameObject target = hit.collider.gameObject;
                    heldDown = true;
                }
            }

            if (theMode == clickMode.clickOn)
            {
                if (hit.collider != null)
                {
                    GameObject target = hit.collider.gameObject;
                    Debug.Log("Mouse Clickered " + target.name);

                    if (target.gameObject.GetComponent<Food>() != null)
                    {
                        target.GetComponent<Food>().ClickedUpon();

                    }

                    else if (target.gameObject.GetComponent<PrefabSpawner>() != null)
                    {
                        target.GetComponent<PrefabSpawner>().ClickedUpon();

                    }

                    else if (target.gameObject.GetComponent<Boilable>() != null)
                    {
                        target.GetComponent<Boilable>().ClickedUpon();
                    }


                }
            }
        }
        if (Input.GetMouseButton(0) && heldDown)
        {

        }
        if (Input.GetMouseButtonUp(0))
        {
            heldDown = false;
        }
    }
}
