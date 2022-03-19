using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDelay : MonoBehaviour
{
	public float delay = 3;
    public AudioSource audioData;

	// Use this for initialization
	void Start() 
	{
        audioData = GetComponent<AudioSource>();
		audioData.PlayDelayed(delay);
        
	}
}

