using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Vector3 direction;
    [SerializeField]
    float ballSpeed = 5f;

    private void Start()
    {
        direction = new Vector3(Random.Range(-1f,1f), 1f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Choca pelota");

        if (collision.gameObject.CompareTag("Brick"))
        {
            direction = new Vector3(Random.Range(-1f, 1f), -direction.y, 0f);
            BrickComponent brick = collision.gameObject.GetComponent<BrickComponent>();
            brick.RecieveHit();
            
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            direction = new Vector3(Random.Range(-1f,1f), -direction.y, 0f);

        }
        else if (collision.gameObject.CompareTag("BorderLateral"))
        {
            direction = new Vector3(-direction.x, direction.y, 0f);


        }
        else if (collision.gameObject.CompareTag("BorderUp"))
        {
            direction = new Vector3(-direction.x, -direction.y, 0f);

        }
        else if (collision.gameObject.CompareTag("BorderDown"))
        {
            Debug.Log("Reset Ball");
            transform.position = new Vector3(0f, -4f, 0f);
            direction = new Vector3(Random.Range(-1f, 1f), 1f, 0f);

        }
    }
}
