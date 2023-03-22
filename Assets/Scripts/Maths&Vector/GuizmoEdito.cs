using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GuizmoEdito : MonoBehaviour
{
    [SerializeField, Range(0.1f,10f)] float size;
    //[SerializeField, Range(0.1f,10f)] float size2;

    //[SerializeField] Transform circle2;
    [SerializeField] GuizmoEdito guizmoEdito;
    
    void OnDrawGizmos()
    {
        //float dist = Vector3.Distance(x.position, transform.position);

        // Vector3 offset = x.transform.position - transform.position;

        //float sqrLen = offset.sqrMagnitude;
        float sqrLen = (guizmoEdito.transform.position-transform.position).sqrMagnitude;
        sqrLen = sqrLen - (size + guizmoEdito.size);

        if (sqrLen >= size+guizmoEdito.size)
        {
            Gizmos.color = Color.white;
        }
        else
        {
            Gizmos.color = Color.yellow;
        }
        Gizmos.DrawSphere(transform.position, size);
    }
}