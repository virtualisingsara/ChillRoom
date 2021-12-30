using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Paths : MonoBehaviour
{
	[SerializeField, Range(8, 20)] private int reverseSpeed = 14;
	public Transform target;
	public PathType pathType = PathType.CatmullRom;
	public Vector3[] waypoints = new[] {
		new Vector3(-1, 0, 2),
		new Vector3(-2, 0, 4),
		new Vector3(2, 0, 2),
	};

	void Start()
	{
		// Create a path tween using the given pathType, Linear or CatmullRom (curved).
		// Use SetOptions to close the path
		// and SetLookAt to make the target orient to the path itself
		Tween t = target.DOPath(waypoints, reverseSpeed, pathType)
			.SetOptions(true)
			.SetLookAt(0.001f);
		// Then set the ease to Linear and use infinite loops
		t.SetEase(Ease.Linear).SetLoops(-1);
	}
}