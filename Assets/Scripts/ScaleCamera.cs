using UnityEngine;
using System.Collections;

public class ScaleCamera : MonoBehaviour {
	public float orthographicSize;
	public float aspect;

	// Use this for initialization
	void Start () {
		Camera.main.projectionMatrix = Matrix4x4.Ortho(
			-orthographicSize * aspect, orthographicSize * aspect,
			-orthographicSize, orthographicSize,
			camera.nearClipPlane, camera.farClipPlane);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
