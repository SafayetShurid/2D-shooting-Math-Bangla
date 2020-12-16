using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number_Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector2.down * 3f*Time.deltaTime);
        if(transform.position.y<-6.37f)
        {
            Destroy(this.gameObject);
        }
	}
}
