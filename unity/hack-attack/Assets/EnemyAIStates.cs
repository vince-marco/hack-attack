using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIStates : MonoBehaviour
{}//This is just here to make Unity happy. (:
public class TestState : IState 
{
    EnemyAI owner;

    public TestState (EnemyAI owner) {this.owner = owner;}
    public GameObject myParentObject;
    public void Enter(GameObject parentObject){
        Debug.Log("entering test state, my object is:" + parentObject);
        myParentObject = parentObject;
    }
    public void Execute(){
        Debug.Log("executing test state");
    }
    public void Exit(){
        Debug.Log("exit test state");
    }
}
public class Inactive : IState 
{
    EnemyAI owner;

    public Inactive (EnemyAI owner) {this.owner = owner;}

    public GameObject myParentObject;
    public com.ootii.Actors.SpiderAIDriver myController;
    public EnemyAI myAI;
    

    public void Enter(GameObject parentObject){
        Debug.Log("entering test state, my object is:" + parentObject);
        myParentObject = parentObject;
        myController = myParentObject.GetComponentInChildren<com.ootii.Actors.SpiderAIDriver>();
        myController.Target = null;
        myAI = parentObject.GetComponent<EnemyAI>();
        //myAI.IsInvoking = false;
    }
     public void Execute(){
        Debug.Log("executing test state");
        //Do Nothing
        //Idle or Inactive Animation?
    }
    public void Exit(){
        Debug.Log("exit test state");
        //Do Nothing
        //Reactivate Animation?
    }
}
public class Patrol : IState 
{
    EnemyAI owner;

    public Patrol (EnemyAI owner) {this.owner = owner;}
    public GameObject myParentObject;
    public com.ootii.Actors.SpiderAIDriver myController;
    public EnemyAI myAI;
    public GameObject PathNest;
    public Transform[] PathTranforms;

    public void Enter(GameObject parentObject){
        Debug.Log("entering test state, my object is:" + parentObject);
        myParentObject = parentObject;
        myController = myParentObject.GetComponentInChildren<com.ootii.Actors.SpiderAIDriver>();
        myAI = parentObject.GetComponent<EnemyAI>();
        /* for(int i; i < ;i++){
            Transform[] 
        }
        myController.Target = PathTranforms[0];
        myAI.IsInvoking = true;
         */
        //Set 1st Patrol Point: Robot/SpiderAIDriver/Target(Transform)
    }
    public void Execute(){
        Debug.Log("executing test state");
        //Check for reaching 1st Patrol Point
        //If yes, Set nth Patrol Point + 1: Robot/SpiderAIDriver/Target(Transform)
        //else do nothing
    }
    public void Exit(){
        Debug.Log("exit test state");
        //Do Nothing
    }
}
public class Chase : IState 
{
    EnemyAI owner;

    public Chase (EnemyAI owner) {this.owner = owner;}

    public void Enter(GameObject parentObject){
        Debug.Log("entering test state, my object is:" + parentObject);
        //Set Player: Robot/SpiderAIDriver/Target(Transform)
    }
    public void Execute(){
        Debug.Log("executing test state");
        //If Drone is within x distance from player: Gameover
    }
    public void Exit(){
        Debug.Log("exit test state");
    }
}