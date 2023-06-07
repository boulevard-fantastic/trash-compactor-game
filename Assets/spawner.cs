using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public List<GameObject> block;
    public float timer = 0;
    public int blocksSpawned = 0;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) {
            GameObject newBlock = Instantiate(block[(int)(Mathf.PerlinNoise(0f,Time.timeSinceLevelLoad) * block.Count)],transform.position + new Vector3 (Mathf.PerlinNoise(0f,Time.timeSinceLevelLoad) * 32 - 16,32f + transform.localScale.y / 2,Mathf.PerlinNoise(100f,Time.timeSinceLevelLoad) * 32 - 16), transform.rotation);
            timer += Mathf.Sqrt(Mathf.Pow(Time.timeSinceLevelLoad + 1,-0.25f)) * 5;
            blocksSpawned++;
        }
    }
}
