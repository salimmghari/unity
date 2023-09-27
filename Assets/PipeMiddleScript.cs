using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PipeMiddleScript : MonoBehaviour {
    public LogicManagerScript logicManagerScript;

    void Start() {
        logicManagerScript = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManagerScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        logicManagerScript.addScore(1);
    }
}
