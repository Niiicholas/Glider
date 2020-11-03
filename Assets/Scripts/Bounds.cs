using UnityEngine;

public class Bounds : MonoBehaviour
{
    [SerializeField]
    private Transform[] verticalBounds = new Transform[2];

    private Camera camera;
    void Awake()
    {
        camera = Camera.main;
        if (verticalBounds[0] != null && verticalBounds[1] != null)
            SetBoundsWithScreenSize();
        else
            Debug.LogError("Нет ссылки на объекты вертикальных границ", this);
    }

    void FixedUpdate()
    {
        if (verticalBounds[0] != null && verticalBounds[1] != null)
            SetBoundsWithScreenSize();
    }

    private void SetBoundsWithScreenSize()
    {
        var centerX = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth / 2, 0, 0)).x;
        var topY = camera.ScreenToWorldPoint(new Vector3(0, camera.pixelHeight, 0)).y;
        var bottomY = camera.ScreenToWorldPoint(Vector3.zero).y;
        verticalBounds[0].position = new Vector3(centerX, topY, 0);
        verticalBounds[1].position = new Vector3(centerX, bottomY, 0);
    }
}
