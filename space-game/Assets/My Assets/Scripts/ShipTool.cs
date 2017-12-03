using UnityEngine;

public class ShipTool : MonoBehaviour {

    [SerializeField]
    ShipToolObject tool;
	
    void Update() {
        if (Input.GetMouseButton(0)) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, tool.range);
            if (hit) {
                if (hit.collider.tag == "Interactable") {
                    Harvest(hit.collider.GetComponent<Interactable>());
                } 
            }
        }
    }

    void Harvest(Interactable interactable) {
        interactable.Harvest(tool.amountPerSecond);
    }

    void OnDrawGizmos() {
        if (Input.GetMouseButton(0)) {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.up, tool.range);
            if (hit) {
                if (hit.collider.tag == "Interactable") {
                    Gizmos.DrawLine(transform.position, transform.up * tool.range);
                }
            }
        }
    }
}
