using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {

	public float intervalo;

	IEnumerator Start () {
		
		// Obtem o componente do objeto (Faz o mesmo que o de cima, de forma reduzida).
		GetComponent<Canvas> ().enabled = !GetComponent<Canvas> ().enabled;
		yield return new WaitForSeconds (intervalo);

		// Faz a chamada novamente do método, deixando-o em looping (Recursividade).
		StartCoroutine (Start ());
	}


	// Update is called once per frame
	void Update () {
		if ((Input.GetKey(KeyCode.Return)) || 
			(Input.touchCount == 2)) {
			TargetBlockScript.TargetBlocksTotal = 6;
			SceneManager.LoadScene ("GameScene");			
		}
	}
}
