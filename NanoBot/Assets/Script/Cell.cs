using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    int kindOfCell = Constants.NormalCell;
    int leftDetectNum = 10;

    bool isActivated = false;
    bool isInfected = false;

    Rigidbody thisRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    public void Move(float x, float y)
    {
        transform.position = new Vector3(x, y, 0);
    }

    public void Detect(int power)
    {
        leftDetectNum -= power;
    }

    public void Infect()
    {
        this.isInfected = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
