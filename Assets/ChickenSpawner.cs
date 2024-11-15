using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenSpawner : MonoBehaviour
{

    public GameObject chickenPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown) 
        {
            Instantiate(chickenPrefab, transform.position, gameObject.transform.rotation);
        }
    }
}
