using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.forward = new Vector3 (Mathf.PerlinNoise(1234f,Time.timeSinceLevelLoad),Mathf.PerlinNoise(3949f,Time.timeSinceLevelLoad),Mathf.PerlinNoise(-3949f,Time.timeSinceLevelLoad));
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -16) {
			Destroy(gameObject);
		}
    }
}
