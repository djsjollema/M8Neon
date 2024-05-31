using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    [SerializeField] GameObject Earth;

    [SerializeField] GameObject Moon;

    float EarthRadius = 3f;
    float EarthTheta = 0f; // angle earth in radians
    float EarthDTheta = 0.001f;

    float MoonRadius = 0.5f;
    float MoonTheta = 0f; // angle earth in radians
    float MoonDTheta = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x_earth = EarthRadius * Mathf.Cos(EarthTheta);
        float y_earth = EarthRadius * Mathf.Sin(EarthTheta);

        Earth.transform.position = new Vector3(x_earth, y_earth, 0);

        EarthTheta += EarthDTheta;

        float x_Moon = MoonRadius * Mathf.Cos(MoonTheta);
        float y_Moon = MoonRadius * Mathf.Sin(MoonTheta);

        Moon.transform.position = Earth.transform.position + new Vector3(x_Moon, y_Moon, 0);

        MoonTheta += MoonDTheta;
    }
}
