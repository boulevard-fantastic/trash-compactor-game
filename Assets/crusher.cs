using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crusher : MonoBehaviour
{
    public Transform arm;
    public float timeSinceSlam = 0;
    public List<GameObject> list;
    public pointCounter counter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeSinceSlam >= 0) {
            arm.position = new Vector3 (arm.position.x,Mathf.Lerp(512,544,timeSinceSlam),arm.position.z);
            for (int i=0; i<list.Count; i++) {
                Destroy(list[i]);
                list.RemoveAt(i);
                counter.timeLeft += Mathf.Sqrt(Mathf.Pow(Time.timeSinceLevelLoad + 1,-0.25f)) * 5;
            }
        }
        timeSinceSlam += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) {
        if (other.attachedRigidbody != null) {
            timeSinceSlam = -0.5f;
            list.Add(other.gameObject);
        }
    }
}
