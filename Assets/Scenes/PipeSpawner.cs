using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipeGroupPrefab;
    public float spawnInterval = 2.2f;
    public float heightRange = 3.0f;
    public float spawnX = 6f;

    void Start()
    {
        float interval = GameManager.Instance != null
            ? GameManager.Instance.GetSpawnInterval()
            : spawnInterval;

        InvokeRepeating(nameof(Spawn), 1f, interval);
    }

    void Spawn()
    {
        if (pipeGroupPrefab == null) return;

        float y = Random.Range(-heightRange, heightRange);
        Vector3 pos = new Vector3(spawnX, y, 0f);
        GameObject pipe = Instantiate(pipeGroupPrefab, pos, Quaternion.identity);

        var move = pipe.GetComponent<PipeMove>();
        if (move != null && GameManager.Instance != null)
            move.speed = GameManager.Instance.GetPipeSpeed();
    }
}
