using UnityEngine;
using System;

public class ClockAnimator : MonoBehaviour {
	public Transform hours, minutes, seconds;
		public bool analog;

	private const float 
		hoursToDegrees = 360f / 12f,
		minutesToDegrees = 360f / 60f,
		secondstoDegrees = 360f / 60f;


	void Update () {
				if (analog) {
						TimeSpan timespan = DateTime.Now.TimeOfDay;
						hours.localRotation = Quaternion.Euler (0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
						minutes.localRotation = Quaternion.Euler (0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
						seconds.localRotation = Quaternion.Euler (0f, 0f, (float)timespan.TotalSeconds * -secondstoDegrees);
				} else {
						DateTime time = DateTime.Now;
						hours.localRotation = Quaternion.Euler (0f, 0f, time.Hour * -hoursToDegrees);
						minutes.localRotation = Quaternion.Euler (0f, 0f, time.Minute * -minutesToDegrees);
						seconds.localRotation = Quaternion.Euler (0f, 0f, time.Second * -secondstoDegrees);
				}
		}

}

