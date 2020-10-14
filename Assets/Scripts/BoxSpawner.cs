using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    // Spawners 
    public Transform[] spawners;

    // float 
    public float spawnTime;
    float time;

    // boxes
    public GameObject[] boxes;

    private void FixedUpdate() {
        if(time >= spawnTime)
        {
            Instantiate(boxes[Random.Range(0,boxes.Length)],spawners[Random.Range(0,spawners.Length)].position,Quaternion.identity,null);
            time = 0;
        }       
        else
        {
            time += Time.deltaTime;
        }
    }

}
