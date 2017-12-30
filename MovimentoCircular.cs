using System.Collections;
using UnityEngine;

public class MovimentoCircular : MonoBehaviour {

	private float tempo = 0;

	void Start () {

	}

  void Update () {

    tempo += Time.deltaTime;   // -= para rodar sentido anti-horario

		float y = 3* Mathf.Sin (tempo);
		float x = 3* Mathf.Cos (tempo);

    transform.position = new Vector2 (y,x);
	}
}
