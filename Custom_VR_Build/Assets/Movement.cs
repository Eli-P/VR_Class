using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10;
    private Transform cam;
    private float lr;
    private float fb;
    // Start is called before the first frame update
    void Start()
    {
        cam = transform.GetChild(0).GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, cam.rotation.y, transform.rotation.z));
        fb = Input.GetAxis("Vertical");
        lr = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * fb * Time.deltaTime * speed);
        transform.Translate(Vector3.left * lr * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
            cam.Rotate(Vector3.forward * speed * 5 * Time.deltaTime);
    }
}
