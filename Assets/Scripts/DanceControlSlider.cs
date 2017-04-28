using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceControlSlider : MonoBehaviour {

	public AudioClip musicClip;
	public int bpm;
	public List<AudioClip> beatAccents;
	public GameObject sliderObject;
	public GameObject cmdPrefab;

	private float barWidth;
	private float cmdPrefabWidth;
	


	// Use this for initialization
	void Start () {
		cmdPrefabWidth = cmdPrefab.GetComponent<RectTransform>().rect.width;
		calculateSong(musicClip, bpm);
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKeyDown(KeyCode.LeftArrow) ||
			Input.GetKeyDown(KeyCode.RightArrow) ||
			Input.GetKeyDown(KeyCode.UpArrow) ||
			Input.GetKeyDown(KeyCode.DownArrow)) {
				DoShit(Input.inputString);
		}
	}

	void calculateSong(AudioClip musicClip, int bpm) {
		float songLength = musicClip.length;
	}

	void createSong(List<AudioClip> musicClips) {
		//Creates a song from AudioClips in a list
		bool hasAccent = false;
		bool hasIntermission = false;

		AudioClip baseBeat = musicClips[0];
		if (musicClips.Count > 1) {
			AudioClip accentBeat = musicClips[1];
			hasAccent = true;
		}
		if (musicClips.Count > 2) {
			AudioClip intermission = musicClips[0];
			hasIntermission = true;
		}
	}
}
