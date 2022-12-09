using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    protected bool doneNess = false;
    public int maxPrep = 10;
    public int currPrep = 0;
    public GameObject thisFood;
    public GameObject doneCount;
    public Boilable boilBoy;
    public void ClickedUpon()
    {
        doneCount = GameObject.Find("Counter");

        if (!(doneNess))
        {
            currPrep++;
            if (currPrep == maxPrep)
            {
                doneNess = true;
            }
        }
        if (this.GetComponent<SpriteRenderer>().flipX == true)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        else this.GetComponent<SpriteRenderer>().flipX = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doneNess)
        {
            doneCount.GetComponent<Counter>().doneCounter++;

            Destroy(gameObject);
        }
    }
}
