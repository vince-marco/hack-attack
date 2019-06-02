using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineHolder : MonoBehaviour
{}//This is just here to make Unity Happy.
public interface IState{
    void Enter(GameObject parentObject);
    void Execute();

    void Exit();
}
public class StateMachine {
    public IState currentState;
    public void ChangeState(IState newState, GameObject parentObject){
        if(currentState != null){
            currentState.Exit();
        }
        
        currentState = newState;
        currentState.Enter(parentObject);
    }
    public void Update(){
        if(currentState != null) currentState.Execute();
    }
}