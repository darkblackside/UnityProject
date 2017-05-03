using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

    public float Rotation { get; set; }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.Rotate(new Vector3(0, Rotation, 0));
    }

    public void ToggleRotation()
    {
        if (Rotation == 0)
        {
            Rotation = -0.1f;
        }
        else
        {
            Rotation = 0;
        }
    }
}
