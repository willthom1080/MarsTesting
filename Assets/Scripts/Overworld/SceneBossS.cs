using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneBossS : MonoBehaviour
{
    public GameObject thePlayer;
    public void onEvent()
    {
        switch (thePlayer.transform.position.x)
        {
            case -0.5f: Debug.Log("theDoor");
                break;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
