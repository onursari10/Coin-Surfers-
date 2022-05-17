using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
    GameObject MainCoin;
    float height;

    void Start()
    {
        MainCoin = GameObject.Find("GoldCoin");
        
    }

    
    void Update()
    {
        MainCoin.transform.position = new Vector3(transform.position.x, height + 0.02f, transform.position.z);
        this.transform.localPosition = new Vector3(0, -height, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "collect")
        {
            height += 1;
            other.gameObject.GetComponent<Coins>().Collected();
            other.gameObject.GetComponent<Coins>().setIndex(height);
            other.gameObject.transform.parent = MainCoin.transform;

        }
    }
}
