using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEffect : MonoBehaviour {

    public GameObject GroundPound;
    public GameObject explosion;
    public GameObject RockChunk;

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(GroundPound, this.transform);
        Instantiate(explosion, this.transform);
        Instantiate(RockChunk, new Vector3(transform.position.x,transform.position.y+2,transform.position.z),RockChunk.transform.rotation);

    }
}
