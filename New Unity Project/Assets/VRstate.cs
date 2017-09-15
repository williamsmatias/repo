using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRstate : MonoBehaviour {

	 void Update(){
		if (Cardboard.SDK.VRModeEnabled != EstadoApp.estadoApp.vrEnable) {
			Cardboard.SDK.VRModeEnabled = EstadoApp.estadoApp.vrEnable; 
		}
	}
}
