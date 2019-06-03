using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public com.ootii.Actors.SpiderAIDriver myController;
    public Transform[] Path = new Transform[3];
    public int currentMarker;
    StateMachine stateMachine = new StateMachine();
    bool isLooking = true;
    void Start(){
        myController = gameObject.GetComponent<com.ootii.Actors.SpiderAIDriver>();
        stateMachine.ChangeState(new TestState(this), gameObject);
        Debug.Log("Changing State to:" + stateMachine.currentState);
    }
    void Update(){
        stateMachine.Update();
    }
    public void SetDestination(Transform target){
        myController.Target = target;        
    }
    public void Cyclepath(){
        if(currentMarker >= 2){
            currentMarker = 2;
        }
        else{ currentMarker ++;}
        SetDestination(Path[currentMarker]);
    }
}


