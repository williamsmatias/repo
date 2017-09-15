using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoApp : MonoBehaviour {

	public bool vrEnable = true;

	public static EstadoApp estadoApp;

	//Awake se carga primero que start, cuando comienza start awake ya esta cargado
	void Awake(){
		if (estadoApp == null) {
			estadoApp = this;
			//le decimos que no se destruya el objeto al cual hemos puesto este componente
			DontDestroyOnLoad (gameObject);
		} else if (estadoApp != this) {
			Destroy (gameObject);
		}

	}

	// Use this for initialization
	void Start () {
		vrEnable = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
