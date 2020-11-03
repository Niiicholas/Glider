using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunksSettings : MonoBehaviour
{
    [SerializeField]
    private float chunkWidth = 1f;

    void Awake()
    {
        SetChunkSizeWithScreenSize();
    }

    void FixedUpdate()
    {
        SetChunkSizeWithScreenSize();
    }

    private void SetChunkSizeWithScreenSize()
    {
        var camera = Camera.main;
        var chunkHeight = camera.ScreenToWorldPoint(new Vector3(0, camera.pixelHeight, 0)).y;
        var chunkScale = new Vector3(chunkWidth, chunkHeight, 1);
        transform.localScale = chunkScale;
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, transform.localScale);
    }
}
