using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    StateMachine stateMachine = new StateMachine();
    bool isLooking = true;
    void Start(){
        stateMachine.ChangeState(new TestState(this), gameObject);
        Debug.Log("Changing State to:" + stateMachine.currentState);
    }
    void Update(){
        stateMachine.Update();
    }
}


