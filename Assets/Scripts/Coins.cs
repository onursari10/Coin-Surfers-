using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    bool collect;
    float index;
    
    void Start()
    {
        collect = false;
    }

    
    void Update()
    {
        transform.localPosition = new Vector3(0, -index, 0);
    }

    public bool isCollect()
    {
        return collect;
    }

    public void Collected()
    {
        collect = true;
    }

    public void setIndex(float index)
    {
        this.index = index; 
    }
}
