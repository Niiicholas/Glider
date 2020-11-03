using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public sealed class PlayerMovement : MonoBehaviour
{
    public bool pcInput = true;

    [SerializeField]
    [Range(0, 10)]
    private float velocity = 4; // 4 is optimal

    [SerializeField]
    private Rigidbody2D rigidbody;

    private Camera camera;

    private void Awake()
    {
        camera = Camera.main;
        SetPositionWithScreenSize();
    }

    private void FixedUpdate()
    {
        CheckInputs();
        SetPositionWithScreenSize();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals(Barrier.TAG))
        {
            Debug.Log("Collision with the barrier!");
            //TODO: Обра    ботка события столкновения
        }
    }

    private void CheckInputs()
    {
        float axis = 0;
        if (pcInput == false)
            axis = Input.acceleration.x;
        else
            axis = Input.GetAxis("Vertical");
        rigidbody.AddForce(Vector2.up * axis * velocity, ForceMode2D.Force);
    }

    private void SetPositionWithScreenSize()
    {
        var quarterOfScreen = camera.pixelWidth * 0.25f;
        var positionX =camera.ScreenToWorldPoint(new Vector3(quarterOfScreen, 0, 0)).x;
        transform.position = new Vector3(positionX, transform.position.y, transform.position.z);
    }
}
