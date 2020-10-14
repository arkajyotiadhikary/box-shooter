using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Boxes_Movement : MonoBehaviour
{

    // float
    public float boxUpwardForce;
    float time;
    public float boxDestroyTime;

    // rigidbody
    Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up*boxUpwardForce,ForceMode.Impulse);
        rb.AddRelativeTorque(Vector3.right*Random.Range(0,20));
    }
      private void Update() {
            
            if(time >= boxDestroyTime)
            {
                Destroy(gameObject);
            }
            else
            {
                time += Time.deltaTime;
            }
        }
}
