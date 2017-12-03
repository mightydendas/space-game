using UnityEngine;

public class Utils {

	public static Vector2 Vector2(Vector3 vector) {
        return new Vector2(vector.x, vector.y);
    }

    public static Vector3 Vector3(Vector2 vector) {
        return new Vector3(vector.x, vector.y);
    }

    public static Vector2 GetMousePosition() {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
