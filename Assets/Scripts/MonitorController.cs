using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class MonitorController : MonoBehaviour {

	private bool isRunning = false;

	public void Run() {
		VideoPlayer player = this.GetComponent<VideoPlayer> ();
		if (!isRunning) {
			player.Play ();
			isRunning = true;
		} else {
			player.Pause ();
			isRunning = false;
		}
	}
}
