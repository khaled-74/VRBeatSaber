using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float cubeSpeed;
    public float destroyspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,destroyspeed);
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate(Vector3.forward * Time.deltaTime * cubeSpeed);

    }
}
