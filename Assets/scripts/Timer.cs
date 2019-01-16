using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float PSTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        PSTimer -= Time.deltaTime;
        if (PSTimer <= 0)
            Destroy(gameObject);
	}
}
