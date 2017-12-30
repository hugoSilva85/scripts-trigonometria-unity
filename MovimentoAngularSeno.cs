using System.Collections;
using UnityEngine;

public class MovimentoAngularSeno : MonoBehaviour {

	private float tempo = 0;

	void Start () {

	}

  void Update () {

    tempo += Time.deltaTime;

		float y = Mathf.Sin (tempo);

    transform.position = new Vector2 (y,y); // Para fazer o movimento inversamente proporcional (-y,y); 
	}
}
