using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabber : MonoBehaviour
{
    Rigidbody heldObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;int layerMask = 1 << 8;

            layerMask = ~layerMask;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f, layerMask))
            {
                if (hit.rigidbody != null) {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    heldObject = hit.rigidbody;
                }
            }
        }
        else if (Input.GetMouseButtonUp(0)) {
            heldObject = null;
            heldObject.velocity = ((transform.position + transform.forward * 2) - heldObject.position) * 20;
        }
        if (Input.GetMouseButton(0) && heldObject != null) {
            heldObject.velocity = Vector3.Lerp(heldObject.velocity,((transform.position + transform.forward * 2) - heldObject.position) * 20,Time.deltaTime * 20);
        }
    }
}
