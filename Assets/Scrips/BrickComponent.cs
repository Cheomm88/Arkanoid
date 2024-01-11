using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickComponent : MonoBehaviour
{
    public int points = 10;
    public int hitsToDie = 1;

    public void RecieveHit()
    {
        hitsToDie--;
        if(hitsToDie == 0)
        {
            PointsManager.instance.AddPoints(points);
            Destroy(gameObject);    
        }
    }
}
