using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float forward;
    [SerializeField]
    private float right;





    void Start()
    {
        
    }

    
    void Update()
    {
        float yatay = Input.GetAxis("Horizontal") * right * Time.deltaTime;

        transform.Translate(yatay, 0, forward * Time.deltaTime);

        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "turn")
        {
            float NTurn = transform.rotation.y + 90;
            transform.Rotate(0, NTurn, 0);
        }
    }

    
    
        
    
}
