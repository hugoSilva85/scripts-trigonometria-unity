using System.Collections;
using UnityEngine;

public class MovimentoHorizontalSeno : MonoBehaviour {

	private float tempo = 0;

	void Start () {

	}

  void Update () {

    tempo += Time.deltaTime;

		//float x = Mathf.Cos (tempo); não inicia na posição 0 olhar tabela cosseno
		float x = Mathf.Sin (tempo);

    transform.position = new Vector2 (x,0); // muda apenas o eixo 
	}
}
