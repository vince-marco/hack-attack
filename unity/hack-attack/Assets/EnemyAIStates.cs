using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIStates : MonoBehaviour
{}//This is just here to make Unity happy. (:
public class Inactive : IState 
{
    EnemyAI owner;

    public Inactive (EnemyAI owner) {this.owner = owner;}

    public GameObject myParentObject;
    public void Enter(GameObject parentObject){
        myParentObject = parentObject;
        owner.SetDestination(null);
    }
     public void Execute(){
         owner.CheckForActivation();
    }
    public void Exit(){
    }
}
public class Patrol : IState 
{
    EnemyAI owner;

    public Patrol (EnemyAI owner) {this.owner = owner;}
    public GameObject myParentObject;

    public EnemyAI myController;

    public void Enter(GameObject parentObject){
        myController = parentObject.GetComponentInChildren<EnemyAI>();
        owner.Cyclepath();
    }
    public void Execute(){
       // Debug.Log(myController.gameObject.GetComponentInChildren<Transform>().gameObject);
       // Debug.Log(myController.Path[myController.currentMarker].gameObject);

        if(Vector3.Distance(myController.gameObject.transform.GetChild(0).position,myController.Path[myController.currentMarker].position) <= 2f){
            myController.Cyclepath();
        }
        owner.CheckForDeactivation();
        owner.CheckForSight();
    }
    public void Exit(){
    }
}
public class Chase : IState 
{
    EnemyAI owner;
    public GameObject myParentObject;

    public Chase (EnemyAI owner) {this.owner = owner;}

    public void Enter(GameObject parentObject){
        owner.SetDestination (owner.playerPosition);
    }
    public void Execute(){
        owner.CheckForNonSight();
        owner.CheckForDeactivation();
        if(Vector3.Distance(owner.myRobot.position, owner.playerPosition.position) <= 1f){
            owner.myLevelManager.LoadLevel("LoseScreen");
       }
    
    }
    public void Exit(){
    }
}