using UnityEngine;

[CreateAssetMenu(fileName ="Ship Tool" ,menuName = "Ship/Ship Tool")]
public class ShipToolObject : ScriptableObject {

    public new string name;
    public ShipToolType type;
    public float amountPerSecond;
    public float range;

    public ShipToolObject(string name, float amountPerSecond) {
        this.name = name;
        this.amountPerSecond = amountPerSecond;
    }

    public enum ShipToolType { Laser, Turret }
}
