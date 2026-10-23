using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject lblMessage;
    
    private bool showMessage = false;
    public float speed;
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PushBall();
        startPos = transform.position;
        lblMessage.SetActive(false);
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
        if (showMessage == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                lblMessage.SetActive(false);
                PushBall();
            }
        }
    }

    public void Restart()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
        transform.position = startPos;
        showMessage = true;
        lblMessage.SetActive(true);
    }


}
