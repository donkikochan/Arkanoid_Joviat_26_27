using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PushBall();
        startPos = transform.position;
    }

    private void PushBall()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 randDirection = Random.insideUnitCircle;
        rb.AddForce(randDirection.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        
        Invoke("PushBall",2.0f);
        transform.position = startPos;
    }


}
