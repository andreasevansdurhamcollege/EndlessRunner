using UnityEngine;

public class Obstacle : MonoBehaviour 
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -10f) 
        {
            Destroy(gameObject);
        }
    }
}
