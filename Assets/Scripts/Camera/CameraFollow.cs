using UnityEngine;
using System.Collections;
public class CameraFollow : MonoBehaviour {
    public Transform target;
    public float smoothing = 5f;

	Vector3 offest;

	void Start(){
		offest = transform.position - target.position;
	}
	void FixedUpdate(){
		Vector3 targetCamPos = target.position + offest;
		transform.position =Vector3.Lerp (transform.position , targetCamPos,smoothing * Time.deltaTime);
	}
}