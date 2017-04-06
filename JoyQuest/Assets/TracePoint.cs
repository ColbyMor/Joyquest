using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Handles when trace point is traced over by mouse.
/// 
/// <author>Colby Morgan</author>
/// <date>04/6/17</date>
/// </summary>
public class TracePoint : MonoBehaviour {
    public Material glowMaterail;//Metarial that is placed when the user traces over object.

    private bool activated = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public bool isActivated()
    {
        return activated;
    }

    void OnMouseOver()
    {
        activate();
    }

    private void activate()
    {
        if (!activated)
        {
            this.gameObject.GetComponent<Renderer>().material = glowMaterail;
            activated = true;
        }
    }
}
