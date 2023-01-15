using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCell : Cell
{
    int HP;
    int maxHP;

    public void Damage(int power)
    {
        HP -= power;
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
