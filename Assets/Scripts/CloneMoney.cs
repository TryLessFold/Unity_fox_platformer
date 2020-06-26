using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CloneMoney : MonoBehaviour
{
    public float distance = 1f;
    public int value = 5;

    void Start()
    {
        if (transform.parent != null)
            CloningCoins(); 
    }

    void CloningCoins() 
    {
        for (int i = 1; i < value; i++)
        {
            GameObject moneyClone = Instantiate(transform.gameObject, new Vector3(transform.position.x + i * distance, transform.position.y, transform.position.z), transform.rotation);
            moneyClone.name = transform.name + (i);
        }
    }
}
