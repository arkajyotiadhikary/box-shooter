using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
        // float 
        public float bulletSpeed;
        public float bulletDestroyTime;
        float time;
        //  rigidbody
        Rigidbody rb;

        private void Start() {
            rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward*bulletSpeed,ForceMode.Impulse);

            if(time >= bulletDestroyTime)
            {
                Destroy(gameObject);
            }
            else
            {
                time += Time.deltaTime;
            }
        }
}
