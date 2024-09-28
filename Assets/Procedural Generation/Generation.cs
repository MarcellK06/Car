using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    [SerializeField]
    private GameObject planePrefab;
    [SerializeField]
    private int minPlanes = 3;
    [SerializeField]
    private int maxPlanes = 10;
    [SerializeField]
    private int numberOfSections = 5;
    [SerializeField]
    private float distanceBetweenPlanes = 1.0f;
    [SerializeField]
    private int minCurvature = -30;
    [SerializeField]
    private int maxCurvature = 30;
    [SerializeField]
    private int minElevation = -10;
    [SerializeField]
    private int maxElevation = 10;
    [SerializeField]

    void Start()
    {
        Vector3 currentPosition = Vector3.zero;
        Quaternion currentRotation = Quaternion.identity;

        // Loop through the number of sections
        for (var k = 0; k < numberOfSections; k++)
        {
            int curvature = Random.Range(minCurvature, maxCurvature);
            int numberOfPlanes = Random.Range(minPlanes, maxPlanes);
            for (int i = 0; i < numberOfPlanes; i++)
            {
                Instantiate(planePrefab, currentPosition, currentRotation);
                if (Random.Range(1, 10) == 3) {
                    int elevation = 0;
                    currentPosition += currentRotation * (Vector3.forward * distanceBetweenPlanes);
                currentRotation *= Quaternion.Euler(elevation, curvature / numberOfPlanes, 0);
                }
                else {
                    currentPosition += currentRotation * Vector3.forward * distanceBetweenPlanes;
                currentRotation *= Quaternion.Euler(0, curvature / numberOfPlanes, 0);
                }
            }
        }
    }

}