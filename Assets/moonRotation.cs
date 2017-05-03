using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonRotation : MonoBehaviour {
    public float Rotation { get; set; }
    public GameObject earth { get; set; }

    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {
        if(earth != null)
        {
            gameObject.transform.RotateAround(earth.transform.position, new Vector3(0, 1, 0), Rotation);
        }
    }

    public void ToggleRotation(GameObject earth)
    {
        this.earth = earth;
        if (Rotation == 0)
        {
            Rotation = -0.2f;
        }
        else
        {
            Rotation = 0;
        }
    }
}
