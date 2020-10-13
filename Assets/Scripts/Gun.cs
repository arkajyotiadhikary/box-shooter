using UnityEngine;

public class Gun : MonoBehaviour
{
    // float 
    public float bulletSpawnTimer;
    float time;
    // transform
    public Transform muzzle;

    // gameobject
    public GameObject bullet;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(time>bulletSpawnTimer)
        {
            time = bulletSpawnTimer;
        }
        else
        {
            time += Time.deltaTime;
        }

        if(Input.GetMouseButtonDown(0) && time == bulletSpawnTimer)
        {
            Instantiate(bullet,muzzle.position,muzzle.rotation,null);
        }        
       
    }
}
