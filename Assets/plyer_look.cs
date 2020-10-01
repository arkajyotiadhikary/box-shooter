using UnityEngine;

public class plyer_look : MonoBehaviour
{
    // Floats
    public float mouseSense;
    public float lookDown, lookUp;
    
    // Transforms
    public Transform look;

    // Vector3
    Vector3 currentLook;
    Vector3 lookAngle;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        currentLook = new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0);

        lookAngle.x += currentLook.x * -mouseSense * Time.deltaTime;
        
        lookAngle.x = Mathf.Clamp(lookAngle.x, -lookDown, lookUp);

        lookAngle.y += currentLook.y *mouseSense* Time.deltaTime;

        this.transform.rotation = Quaternion.Euler(0, lookAngle.y, 0);
        look.rotation = Quaternion.Euler(lookAngle.x, lookAngle.y, 0);
    }
}
