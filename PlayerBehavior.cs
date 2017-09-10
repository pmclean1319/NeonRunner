using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

    public float speed;
    public float maxSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody>().velocity.z < maxSpeed)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
	}
}
