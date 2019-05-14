using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
    public AudioSource sonido;
    public Light luz;
	// Use this for initialization
	void Start () {
        luz.intensity = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Leap")
        {
            sonido.Play();
            luz.intensity = 4;
        }
        if(collision.gameObject.tag == "LeapR")
        {
            sonido.Stop();
            luz.intensity = 0.5f;
        }
    }
}
