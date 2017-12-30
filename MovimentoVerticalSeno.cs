using System.Collections;
using UnityEngine;

public class MovimentoVerticalSeno : MonoBehaviour {

	private float tempo = 0;

	void Start () {
	}

	void Update () {

    tempo += Time.deltaTime;

    //float y = 5 * Mathf.Sin (tempo); Se quiser uma maior amplitude do movimento vertical
		float y = Mathf.Sin (tempo);

    transform.position = new Vector2 (0,y);
	}
}
