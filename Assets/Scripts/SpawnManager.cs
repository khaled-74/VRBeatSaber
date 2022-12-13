using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] cubeType;
    public Transform[] spawnPos;

    public float startDelay = 2;
    public float spawnInterval = 3f;


    private void Start()
    {
        InvokeRepeating("SpawnRandomCube", startDelay, spawnInterval);
    }
    private void Update()
    {

    }
    void SpawnRandomCube() 
    {
        int cubeIndex = Random.Range(0, cubeType.Length);
        int posIndex = Random.Range(0, spawnPos.Length);
        Quaternion cubeRotation = Quaternion.Euler(0, 0, 90 * Random.Range(0,4));

        Instantiate(cubeType[cubeIndex], spawnPos[posIndex].position, cubeRotation);
    }

}

// Rotate a GameObject using a Quaternion.
// Tilt the cube using the arrow keys. When the arrow keys are released
// the cube will be rotated back to the center using Slerp.

public class ExampleScript : MonoBehaviour
{
    float smooth = 5.0f;
    float tiltAngle = 60.0f;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);

        // Dampen towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

    public class Example2 : MonoBehaviour
    {
        float rotateSpeed = 90;

        // Applies a rotation of 90 degrees per second around the Y axis
        void Update()
        {
            float angle = rotateSpeed * Time.deltaTime;
            transform.rotation *= Quaternion.AngleAxis(angle, Vector3.up);
        }
    }
}