using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public KeyCode keyLeft;
    public KeyCode keyRight;

    public GameObject border_right;
    public GameObject border_left;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
        if (Input.GetKey(keyRight) &&
            transform.position.x < border_right.transform.position.x)
        {
            //Right:
            transform.position += Vector3.right * Time.fixedDeltaTime*speed;
        }
        
        if (Input.GetKey(keyLeft)  &&
            transform.position.x > border_left.transform.position.x)
        {
            //Left:
            transform.position -= Vector3.right * Time.fixedDeltaTime*speed;
        }
        
    }
}
