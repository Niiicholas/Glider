using UnityEngine;

[RequireComponent(typeof(ChunksSettings))]
public class BarriersSpawner : MonoBehaviour
{
    [SerializeField]
    private ChunksSettings settings;

    void Awake() {
        if (settings == null)
            Debug.LogError("Пропущена ссылка на настройки чанков", this);
    }

}
