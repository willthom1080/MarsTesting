using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BoilingPot : MonoBehaviour
{
    Boilable[] contentArr;
    public float interval = 1f;
    // Start is called before the first frame update
    void Start()
    {
        contentArr = new Boilable[5];
    }

    // Update is called once per frame
    void Update()
    {
        if(interval > 1f)
        {
            contentArr[0].boilMe();
            Debug.Log("Bam" + Time.deltaTime);
            interval = 0;
        }
    }

    public void plopIn(Boilable newB)
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
