using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour {

    public float Rotation { get; set; }
    public GameObject sun { get; set; }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if(sun != null)
        {
            gameObject.transform.RotateAround(sun.transform.position, new Vector3(0, 1, 0), Rotation);
        }
        gameObject.transform.Rotate(new Vector3(0, Rotation, 0));
    }

    public void ToggleRotation(GameObject sun)
    {
        this.sun = sun;

        if (Rotation == 0)
        {
            Rotation = -1f;
        }
        else
        {
            Rotation = 0;
        }
    }
}
