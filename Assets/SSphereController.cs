using UnityEngine;
using System.Collections;

public class SSphereController : MonoBehaviour {

    public void Shoot(Vector3 dir) {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision other) {
        GetComponent<Rigidbody>().isKinematic = true;
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
