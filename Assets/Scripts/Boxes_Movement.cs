using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Boxes_Movement : MonoBehaviour
{

    // float
    public float boxUpwardForce;

    // rigidbody
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up*boxUpwardForce,ForceMode.Impulse);
        rb.AddRelativeTorque(Vector3.right*Random.Range(0,20));
    }
}
