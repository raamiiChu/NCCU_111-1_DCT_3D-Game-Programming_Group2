using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MouseLook : MonoBehaviour {
    public enum RotationAxes{
        MouseXAndY = 0,
        MouseX =1,
        MouseY =2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9f;
    public float sensitivityVert = 9f;

    public float minmumVert = -45f;
    public float maxmumVert = 45f;

    private float _rotationX = 0;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX = _rotationX - Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minmumVert, maxmumVert);
      
            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(-_rotationX, rotationY, 0);
        } 
        else
        {
            _rotationX-= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minmumVert, maxmumVert);

            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(-_rotationX, rotationY, 0);
        }
	
	}
}