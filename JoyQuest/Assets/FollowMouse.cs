using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Makes the attached GameObject follow the mouse around the screen.
/// <author>Colby Morgan</author>
/// <date>04/6/17</date>
/// </summary>
public class FollowMouse : MonoBehaviour {

    private Vector3 mousePos;
    private float camDist = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePos = Input.mousePosition;
        mousePos.z = camDist;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);

    }
}
