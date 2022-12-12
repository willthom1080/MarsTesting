using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
    public Text theText;
    public GameObject foodMaster;
    public Food foodFoodMaster;
    public int doneCounter;
    public int maxCount;

    // Start is called before the first frame update
    void Start() {
        doneCounter = 0;
        maxCount = 2;
    }


        

    // Update is called once per frame
    void Update() {
       theText.text = doneCounter.ToString();
    }
}




