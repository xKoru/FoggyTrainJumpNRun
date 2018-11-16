using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {
    public Rigidbody2D player;

    private void Start() {
        
    }

    // Update is called once per frame
    void FixedUpdate () {
        if (Input.GetKey(KeyCode.A)) {
            this.player.AddForce(Vector2.left * 10);
        } else if (Input.GetKey(KeyCode.D)) {
            this.player.AddForce(Vector2.right * 10);
        }
    }
}
