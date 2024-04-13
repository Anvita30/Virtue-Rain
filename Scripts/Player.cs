using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    private float xBound, leftBound, rightBound;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        // Calculate bounds based on screen aspect ratio
        CalculateBounds();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (touchPos.x < 0)
            {
                rb.AddForce(Vector2.left * moveSpeed);
            }
            else
            {
                rb.AddForce(Vector2.right * moveSpeed);
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

        // Clamp player's position between leftBound and rightBound
        float clampedX = Mathf.Clamp(transform.position.x, leftBound, rightBound);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }

    void CalculateBounds()
    {
        float screenAspect = (float)Screen.width / (float)Screen.height;
        float cameraHeight = Camera.main.orthographicSize * 2;
        xBound = cameraHeight * screenAspect / 2;

        leftBound = -xBound;
        rightBound = xBound;
    }
}