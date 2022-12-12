using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public int current;
    public Image mask;
    public GameObject focusFood;
    public Food currFood;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Food") != null)
        {
            if(GameObject.FindGameObjectWithTag("Food"))
            focusFood = GameObject.FindGameObjectWithTag("Food");
            currFood = focusFood.GetComponent<Food>();
            maximum = currFood.maxPrep;
            current = currFood.currPrep;
        }
        else
        {
            current = 0;
        }
        GetCurrentFill();
    }

    void GetCurrentFill()
    {
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
    }
}
