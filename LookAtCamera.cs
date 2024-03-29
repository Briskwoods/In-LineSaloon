using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{
    public Transform target;
    public float turnSpeed = .01f;
    Quaternion rotGoal;
    Vector3 direction;

    void Update()
    {
        direction = (target.position - transform.position).normalized;
        rotGoal = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.localRotation, rotGoal, turnSpeed);
    }
}
