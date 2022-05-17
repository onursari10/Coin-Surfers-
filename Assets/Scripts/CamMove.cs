using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public GameObject target;

    public Vector3 offset;
    
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset,2*Time.deltaTime);
    }
}
