using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCounter : MonoBehaviour
{
    public float timeLeft = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "time left: " + ((int)timeLeft).ToString();
        timeLeft -= Time.deltaTime;
    }
}
