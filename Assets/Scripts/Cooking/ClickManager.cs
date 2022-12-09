using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Converts click position to world space whatever that means
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero); //Vector2.zero ensures only objects directly located are detected apparently

            if (hit.collider != null)
            {
                GameObject target = hit.collider.gameObject;
                Debug.Log("Mouse Clickered " + target.name);

                if(target.gameObject.GetComponent<Food>() != null)
                {
                    Food food = target.GetComponent<Food>();
                    food.ClickedUpon();

                }

                else if (target.gameObject.GetComponent<PrefabSpawner>() != null)
                {
                    PrefabSpawner spawner = target.GetComponent<PrefabSpawner>();
                    spawner.ClickedUpon();

                }

                else if (target.tag == "NextStepButton")
                {
                    Debug.Log("fart");

                }


            }
        }
    }
}
