using UnityEngine;
using System.Collections;

public class SSphereGenerator : MonoBehaviour {

    public GameObject SSpherePrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0)) {
            GameObject SSphere = Instantiate(SSpherePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            SSphere.GetComponent<SSphereController>().Shoot(worldDir.normalized * 2000);
        }
	}
}
