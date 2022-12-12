using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boilable : MonoBehaviour
{
    public BoilingPot thePot;

    public int currentDone;
    public int maxDone;

    public void Activate()
    {
        currentDone = 0;
    }
    public void boilMe()
    {
        currentDone++;
    }

    public float getDoneness()
    {
        return  (float)currentDone / (float)maxDone;
    }

    public void ClickedUpon()
    {
        thePot.plopIn(this);
    }
}
