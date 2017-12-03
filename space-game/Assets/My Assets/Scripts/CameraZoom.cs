using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    [SerializeField]
    float zoomSpeed;
    [SerializeField]
    float minZoom;
    [SerializeField]
    float maxZoom;

    void Update () {
		if(Mathf.Abs(Input.GetAxis("Mouse ScrollWheel")) > 0.02f) {
            float value = Input.GetAxis("Mouse ScrollWheel");
            
            if(value > 0 && Camera.main.orthographicSize > maxZoom) {
                Camera.main.orthographicSize -= value * zoomSpeed;
            }
            else if (value < 0 && Camera.main.orthographicSize < minZoom) {
                Camera.main.orthographicSize -= value * zoomSpeed;
            }
        }
	}
}
