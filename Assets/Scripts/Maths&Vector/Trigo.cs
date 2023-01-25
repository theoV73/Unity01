using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigo : MonoBehaviour
{
    [SerializeField, Range(1, 10)] int NBpoints;
    [SerializeField, Range(1, 10)] int densite;
    [SerializeField, Range(1, 10)] int radius;

    private float tau = Mathf.PI * 2;
    void OnDrawGizmos()
    {
        for (int i = 0; i < NBpoints; i += 1)
        {
            float cal1 = (i * tau / NBpoints) ;
            var pointA = new Vector3(Mathf.Cos(cal1), Mathf.Sin(cal1),0) * radius;

            float cal2 = ((i + densite) * tau / NBpoints);
            var pointB = new Vector3(Mathf.Cos(cal2), Mathf.Sin(cal2),0) * radius;

            Gizmos.DrawLine(pointA, pointB);

        }
        for (int i = 0; i < NBpoints; i += 1)
        {
            float cal1 = (i * tau / NBpoints) ;
            var pointA= new Vector3(Mathf.Cos(cal1), Mathf.Sin(cal1),0) * radius;

            float cal2 = ((i+1) * tau / NBpoints);
            var pointB = new Vector3(Mathf.Cos(cal2), Mathf.Sin(cal2),0) * radius;

            Gizmos.DrawLine(pointA, pointB);

        }
       
    }
}
