using UnityEngine;

public class CameraFollow : MonoBehaviour {

    [SerializeField]
    Transform target;
    [SerializeField]
    float positionSmoothTime;
    [SerializeField]
    float rotationSmoothTime;

    Vector3 velocity = Vector3.zero;

	void FixedUpdate() {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, positionSmoothTime);
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, rotationSmoothTime);
    }
}
