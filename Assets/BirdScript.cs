using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BirdScript : MonoBehaviour {
    public Rigidbody2D rigidbody2d;
    public float flapStrength;
    public LogicManagerScript logicManagerScript;
    public bool birdIsAlive = true;

    void Start() {
        logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            rigidbody2d.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logicManagerScript.gameOver();
        birdIsAlive = false;
    }
}
