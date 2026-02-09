using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    [System.Obsolete]
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddScore();
            Destroy(gameObject);
        }
    }
}
