using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{

    private float coin = 0;
    
    private void OnTriggerEnter2D(Collider2D objects)
    {
        if (objects.transform.tag == "coin")
        {
            Destroy(objects.gameObject);
            coin++;
        }
    }
}
