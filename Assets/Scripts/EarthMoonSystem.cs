using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMoonSystem : MonoBehaviour
{
    [SerializeField] GameObject Earth;
    [SerializeField] GameObject Moon;

    Vector3 velocity;
    Vector3 acceleration;
    Vector3 direction;
    float magnitude = 1.0f;

    void Start()
    {

        velocity = new Vector3(0, 0, -1f);
    }

    void Update()
    {
        Earth.transform.Rotate(0, -0.5f, 0);

        Vector3 differenceVector = Earth.transform.position - Moon.transform.position;
        direction = differenceVector.normalized;
        float distance = differenceVector.magnitude;
        magnitude = 5/(distance*distance);

        acceleration = direction * magnitude;
        velocity += acceleration * Time.deltaTime;
        Moon.transform.position += velocity * Time.deltaTime;
        
    }
}
