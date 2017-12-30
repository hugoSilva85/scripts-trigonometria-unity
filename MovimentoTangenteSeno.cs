using System.Collections;
using UnityEngine;

public class MovimentoTangenteSeno : MonoBehaviour {

	private float tempo = 0;
	private Vector2 startPosition;

	void Start () {
		startPosition = transform.position;

	}

  void Update () {

    tempo += Time.deltaTime;

		float x = startPosition.x;

		x += 1 * Mathf.Tan (tempo);

    transform.position = new Vector2 (x,0);
	}
}
