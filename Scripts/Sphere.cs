using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField]
    Transform gemPrefab;

    Transform[] gems;

    [SerializeField]
    static int num = 10;
    float rotateDeg = (Mathf.PI / num) * 2f;
    float posX = 2f, posY = 6f, posZ = 8f;
    float radius = 10f;

    void Awake()
    {
        var position = Vector3.zero;
        var scale = Vector3.one * 0.5f;

        gems = new Transform[num];

        for (int i = 0; i < gems.Length; i++)
        {
            Transform gem = gems[i] = Instantiate(gemPrefab);

            position.x = Mathf.Cos(i * rotateDeg) * radius;
            position.y = posY;
            position.z = Mathf.Sin(i * rotateDeg) * radius;

            gem.localPosition = position;

            gem.localScale = scale;
            gem.SetParent(transform, false);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        float time = Time.time;

        for (int i = 0; i < gems.Length; i++)
        {
            gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * (time + i)) * radius, posY, Mathf.Sin(rotateDeg * (time + i)) * radius); // Spinning circle

            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * time * i) * radius, posY, Mathf.Sin(rotateDeg * time * i) * radius); // Makes a loading circle (keep)
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * time) * radius * i, posY, Mathf.Sin(rotateDeg * time) * radius * i); // Makes a line circle (keep)
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * time) * radius + i, posY, Mathf.Sin(rotateDeg * time) * radius + i); // Makes a hairpin circle (keep?)
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * i) * radius * time, posY, Mathf.Sin(rotateDeg * i) * radius * time); // Makes a shooting star? (keep)
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * time * i) * radius, posY, Mathf.Sin(rotateDeg * i) * radius); // Makes a weird zig-zag pattern (keep)
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * (time + i)) * radius, 3 * Mathf.Sin(Mathf.PI * (posY + time + i)) + 5, Mathf.Sin(rotateDeg * (time + i)) * radius);
                //Up-down alternating spinning circle
            //gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * (time + i)) * radius, 3 * Mathf.Sin(posY + time) + 5, Mathf.Sin(rotateDeg * (time + i)) * radius); // Up-Down spinning circle


        }
    }
}
