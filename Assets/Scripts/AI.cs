using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform target;
    public float speed;

    
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position= Vector3.MoveTowards(transform.position, target.position, step);
        transform.position = new Vector3(transform.position.x,0.97f ,transform.position.z);
        transform.LookAt(target);
}
}

