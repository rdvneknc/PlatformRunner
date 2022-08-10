using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public static Transform[] wayPoints;

    void Awake()
    {
        wayPoints = new Transform[transform.childCount];
        for (int i = 0; i < wayPoints.Length; i++)
        {
            wayPoints[i] = transform.GetChild(i);
        }
        // There are 6 children on this object. So; create 6 spaces in the array. Loop all through them (i = 1,2,3...). Then equalize wayPoint number to the child (i).
    }
}
