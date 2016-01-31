using UnityEngine;
using System.Collections;

public class CameraMove_test : MonoBehaviour {
    public float rotationSpeed=1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(0,-10 * Time.deltaTime,0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 10 * Time.deltaTime, 0);
        }
    }
}
