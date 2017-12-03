using UnityEngine;

public class Interactable : MonoBehaviour {

    [SerializeField]
    float amount;

    public void Harvest(float amountPerSecond) {
        if (amount > 0) {
            amount -= amountPerSecond * Time.deltaTime;
        }
        else {
            Destroy(gameObject);
        }
    }

    void OnMouseDown() {
        Debug.Log("Interacting");
    }
}
