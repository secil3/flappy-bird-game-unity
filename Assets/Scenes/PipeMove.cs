using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed = 2.5f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -6f)
        {
            Destroy(gameObject);
        }
    }
}
