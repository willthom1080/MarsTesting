using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BoilingPot : MonoBehaviour
{
    Boilable[] contentArr;
    // Start is called before the first frame update
    void Start()
    {
        contentArr = new Boilable[5];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void plopIn(Boilable newB)
    {
        newB.boilMe();
        for (int i = 0; i < contentArr.Length; i++) { 
            if (!(contentArr[i]))
            {
                contentArr[i] = newB;
            }
        }
    }
}
