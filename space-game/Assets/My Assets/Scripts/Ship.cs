using UnityEngine;

public class Ship : MonoBehaviour {

    
    public float interactionRange;

	

    void OnDrawGizmos() {
        if (Input.GetMouseButton(0)) {
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, Utils.GetMousePosition() - Utils.Vector2(transform.position));
        }
            
    }
}
