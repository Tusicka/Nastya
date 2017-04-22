using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float speed;
    private Rigidbody _rb;
    // Use this for initialization
    void Start() {
   _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        _rb.AddForce(direction*speed);
    }
}
