using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private KeyCode forward;
    [SerializeField] private KeyCode back;
    [SerializeField] private KeyCode right;
    [SerializeField] private KeyCode left;

    [SerializeField] private Rigidbody rb;

    [SerializeField] private float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveByRigibody();
    }

    void MoveByRigibody()
    {
        float dl = Time.deltaTime * speed;
        Vector3 result = Vector3.zero;
        if (Input.GetKey(forward))
            result += Vector3.forward; 
        if (Input.GetKey(back))
            result += Vector3.back;
        if (Input.GetKey(right))
            result += Vector3.right;
        if (Input.GetKey(left))
            result += Vector3.left;
        if (result!= Vector3.zero)
        {
            rb.MovePosition(result * dl + transform.position);
            transform.forward = result.normalized;
        }

    }
}
