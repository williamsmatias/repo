using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVRmode : MonoBehaviour {

	public void ToggleVR(){
		Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
		EstadoApp.estadoApp.vrEnable = Cardboard.SDK.VRModeEnabled; 
	}
}
