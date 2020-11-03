using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Barrier : MonoBehaviour
{
    public static readonly string TAG = "Barrier";

    private void Awake() {
        gameObject.tag = TAG;
    }
}
