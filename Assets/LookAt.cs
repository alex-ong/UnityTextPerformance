using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {    
	// Use this for initialization
	void Start () {
        if (this.transform.position != Vector3.zero)
            this.transform.rotation = Quaternion.LookRotation(this.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
