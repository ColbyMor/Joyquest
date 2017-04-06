using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Finger tracing script creates spheres along the path the user traces.
/// </summary>
public class FingerTracing : MonoBehaviour {

    public GameObject shapePrfab;//GameObject that will be used for visually showing path.
    public float shapeSpace = 0.2f; //Distance beetween shapes

    private GameObject shapeParent;//All tracing shapes are child of this object. For easy clean up.
    private Vector3 currPos ;
    private float camDist = 10.0f;
    private Vector3 pos;
    private GameObject shape;

    private void Start()
    {
        shapeParent = new GameObject();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pos = Input.mousePosition;
            pos.z = camDist;
            currPos = Camera.main.ScreenToWorldPoint(pos);
            shape = Instantiate(shapePrfab) as GameObject;
            shape.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            shape.transform.position = currPos;
            shape.transform.parent = shapeParent.transform;
        }
        
        if (Input.GetMouseButton(0))
        {
            pos = Input.mousePosition;
            pos.z = camDist;
            pos = Camera.main.ScreenToWorldPoint(pos);
            if (Vector3.Distance(pos, currPos) > shapeSpace)
            {
                shape = Instantiate(shapePrfab) as GameObject;
                shape.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                shape.transform.position = pos;
                currPos = pos;
                shape.transform.parent = shapeParent.transform;
            }
        }
        
    }

}
