using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D spriteBody;
    float speed = 5.0f;
    float horizontalMovement, verticalMovement;

    void spriteMovement() {
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
        //    spriteBody.velocity = Vector2.up * 5;
        //}

        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
        //    spriteBody.velocity = Vector2.down * 5;
        //}

        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
        //    spriteBody.velocity = Vector2.left * 5;
        //}
        
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
        //    spriteBody.velocity = Vector2.right * 5;
        //}

        horizontalMovement = Input.GetAxisRaw("Horizontal");
        verticalMovement = Input.GetAxisRaw("Vertical");
        Vector2 directionalMovement = new Vector2(horizontalMovement, verticalMovement);
        directionalMovement.Normalize();
        spriteBody.MovePosition(spriteBody.position + directionalMovement * speed * Time.fixedDeltaTime);
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

    }

    void FixedUpdate() {
        spriteMovement(); 
    }
}
