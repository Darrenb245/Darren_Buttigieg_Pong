using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        float mouseUnits = (Input.mousePosition.y / Screen.height * 13f) - 6.5f;
        float mousePos = Mathf.Clamp(mouseUnits, -4.2f, 2.3f);
        Vector3 paddlePosition = new Vector3(2.72f, mousePos, this.transform.position.x);
        this.transform.position = paddlePosition;
		
	}
}
