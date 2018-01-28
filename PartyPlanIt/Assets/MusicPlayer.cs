using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	AudioSource myAudio;

	public AudioClip polka;
	public AudioClip elevator;
	public AudioClip pop;
	public AudioClip chamber;

	// Use this for initialization
	void Start () {
		myAudio = GetComponent<AudioSource>();
	}

	public void newSong()
	{
		ReviewGenerator generator = GameObject.FindObjectOfType<ReviewGenerator>();
		if(generator.musicGot == Options.Music.Chamber)
		{
			myAudio.clip = chamber;
		}else if(generator.musicGot == Options.Music.Elevator)
		{
			myAudio.clip = elevator;
		}
		else if (generator.musicGot == Options.Music.Polka)
		{
			myAudio.clip = polka;
		}
		else if (generator.musicGot == Options.Music.Pop)
		{
			myAudio.clip = pop;
		}
		myAudio.Play();
	}

	// Update is called once per frame
	void Update () {

	}
}