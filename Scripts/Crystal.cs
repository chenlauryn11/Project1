using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField]
    Transform gemPrefab;

    [SerializeField]
    static int num = 10;
    float rotateDeg = (Mathf.PI / num) * 2f;
    float posX = 2f, posY = 0f, posZ = 8f;
    float radius = 0.1f;

    
    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        gemPrefab.localPosition = new Vector3(Mathf.Cos(rotateDeg * time) * radius, posY, Mathf.Sin(rotateDeg * time) * radius); // Spinning circle
    }
}
