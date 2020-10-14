using UnityEngine;
using System.Collections;
public class Box_Destroy : MonoBehaviour
{
    public ParticleSystem destroyPartical;

    public GameObject[] design;
    public Canvas text;

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Bullet"))
        {
            StartCoroutine(destroy());
        }
    }

    IEnumerator destroy()
    {
        GetComponent<Collider>().enabled = false;
        
        if(text != null)
        {
            text.enabled = false;
        }

        if(design != null)
        {
            foreach(GameObject dsn in design)
            {
                Destroy(dsn);
            }
        }
        
        GetComponent<MeshRenderer>().enabled=false;
        destroyPartical.Play();
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
