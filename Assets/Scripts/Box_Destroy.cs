using UnityEngine;
using System.Collections;
public class Box_Destroy : MonoBehaviour
{
    public ParticleSystem destroyPartical;

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Bullet"))
        {
            StartCoroutine(destroy());
        }
    }

    IEnumerator destroy()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled=false;
        destroyPartical.Play();
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
