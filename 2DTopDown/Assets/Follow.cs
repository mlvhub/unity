using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform target;

	void Update () {
		Vector3 targetPosition = target.position;
		targetPosition.z = this.transform.position.z;
		this.transform.position = targetPosition;
	}
}
