using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Detects when all of the trace points are activated and then changes to the next scene.
/// 
/// <author>Colby Morgan</author>
/// <date>04/6/17</date>
/// </summary>
public class Rune : MonoBehaviour {
    public string sceneName;//Name of next Scene to load.

    private List<TracePoint> tracePoints;

    // Use this for initialization
    void Start () {
        tracePoints = new List<TracePoint>();
		foreach(Transform c in transform)
        {
            TracePoint t = c.gameObject.GetComponent<TracePoint>();
            if (t != null)
            {
                tracePoints.Add(t);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        bool activated = false;
		foreach(TracePoint t in tracePoints)
        {
            if (t.isActivated())
            {
                activated = true;
            } else
            {
                activated = false;
                return;
            }
        }

        if (activated)
        {
            SceneManager.LoadScene(sceneName);
        }
	}
}
