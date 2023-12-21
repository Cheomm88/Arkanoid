using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryComprobate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Victoria");
        }
    }
}
