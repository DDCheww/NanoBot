using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCell : MonoBehaviour
{
    int leftNumTreat;
    int totalNumTreat;

    public void Treat(int power)
    {
        leftNumTreat -= power;
        if (leftNumTreat < 0)
            leftNumTreat = 0;
    }

    public void Set(int totalNumTreat)
    {
        this.totalNumTreat = totalNumTreat;
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
