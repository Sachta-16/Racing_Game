using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        var coinCount = GameObject.Find("Car").GetComponent<CoinCount>();



        if (other.name == "ColliderBottom")
        {
            coinCount.Points++;
            Destroy(gameObject);
        }
    }
}
