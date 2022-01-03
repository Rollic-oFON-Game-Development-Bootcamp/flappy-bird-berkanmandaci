using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var newPos = new Vector2(transform.localPosition.x + speed * Time.deltaTime, transform.localPosition.y);
        transform.localPosition = newPos;

        if (Input.GetMouseButton(0))
            rigidbody2D.AddForce(Vector2.up*speed*5,ForceMode2D.Force);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Pipe")) return;
        
        Debug.Log("Game Over");
        Time.timeScale = 0;
        GameManager.GetInstance().FinishGame();
        
    }
}
