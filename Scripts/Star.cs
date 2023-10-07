using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
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
            gems[i].localPosition = new Vector3(Mathf.Cos(rotateDeg * time * i) * radius, posY, Mathf.Sin(rotateDeg * i) * radius); // Makes a weird zig-zag pattern (keep)
        }
    }
}
