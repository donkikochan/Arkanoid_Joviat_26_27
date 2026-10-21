using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 randDirection = Random.insideUnitCircle;
        rb.AddForce(randDirection.normalized * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
