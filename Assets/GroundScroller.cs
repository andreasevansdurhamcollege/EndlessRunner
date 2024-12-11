using UnityEngine;

public class GroundScroller : MonoBehaviour 
{
    public float scrollSpeed = 1f;
    public float resetXPosition = -10f;
    public float startXPosition = 10f;

    void Update()
    {
        //move the gorund to the left
        transform.Translate(Vector2.left * scrollSpeed * Time.deltaTime);

        // if the ground goes too far, reset it
        if (transform.position.x < resetXPosition ) 
        {
            Vector2 newPosition = new Vector2(startXPosition, transform.position.y);
            transform.position = newPosition;
        }
    }
}
