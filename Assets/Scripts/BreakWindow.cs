using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWindow : MonoBehaviour {
    public GameObject topWindow;
    public GameObject bottomWindow;
    public ParticleSystem glass;
    public AudioClip clip;
    public AudioSource audioplayer;

    // Use this for initialization
    void Start () {
        audioplayer = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hat")
        {
            audioplayer.PlayOneShot(clip);
            Instantiate(glass, transform.position, Quaternion.identity);
            topWindow.SetActive(false);
            bottomWindow.SetActive(false);
            Destroy(gameObject, 2.6f);
        }
    }
}
