using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    Transform cameraPrefab;

    [SerializeField]
    static int num = 20;
    float rotateDeg = (Mathf.PI / num) * 2f;
    float posX = 30f, posY = 41.9f, posZ = 0f;
    float radius = 100f;

    [SerializeField]
    float rotationSpeed = 10f;

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        cameraPrefab.localPosition = new Vector3(Mathf.Cos(rotateDeg * time) * radius, posY, Mathf.Sin(rotateDeg * time) * radius); // Spinning circle
        cameraPrefab.localRotation = Quaternion.Euler(posX, time * rotationSpeed, posZ);
    }
}
